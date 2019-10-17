using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorColecciones
{
    public partial class frmEdicion : Form
    {

        //---------- Indicar el Adapter y el DataSet 
        ColeccionesDSTableAdapters.LIBROSTableAdapter taLibros; //TableAdapter
        ColeccionesDS ds=new ColeccionesDS();  //TRAMPA 1 :   Instanciar el DataSet
        
                

        //->Constructor del formulario 
        //  donde vamos a pasar un libro inicial,  
        public frmEdicion( int idLibro )
        {

            
            //->Inicializamos el  TableAdapter 
            taLibros = new ColeccionesDSTableAdapters.LIBROSTableAdapter();


            //taLibros.GetData(); //El GetData pilla todos los registros, 
            //                      pero en nuestro caso solo queremos uno así que creamos un nuevo
            //                      filtrado 

            
            //-->Para crear un nuevo filtrado sobre la tabla,  el profre hace lo siguiente :
            //-----------------------------------------------------------------------------
            //Primero :  No vamos a la derecha, al DataSet (gráfico) 
            //Segundo :  En la tabla libros vamos a añadir una segunda consulta 
            //Tecerro :  En este caso será  * USAR INSTRUCCIONES SQL y del tipo  SELECT
            //Cuarto  :  En la select le añadimos un   where IdLibro = @IdLibro  para que solo pille uno
            //Quinto  :  Dejamos los nombres por defecto
            //----------------------------------------------------------//
            //Sexto(1):  Utilizamos la consulta  llamada   GetDataBy recien creada :
            //taLibros.GetDataBy(idLibro);

            //Sexto(2) : Vamos a guardar ese registro en el DataSet  oJo  FillBy  es la segunda consulta            
            taLibros.FillBy(ds.LIBROS, idLibro);



            //Séptimo  : Vamos a rellenar el restos de campos del formulario.             
            InitializeComponent();  // TRAMPA 2 :  Hay que inicializar los controles del formulario 
                                    //             antes de operar con ellos. 


            this.tbxTitulo.Text = ds.LIBROS[0].Titulo;     //¿porque hay que indicar [0] ?
            this.tbxDescricion.Text = ds.LIBROS[0].Descripcion;
            this.dtpCompra.Value =  ds.LIBROS[0].FechaCompra;

            //-->Y ahora para el DataTimePicket que lleva el checked debemos de comprobar primero que la fecha no sea NULL
            //   de lo contrario nos podria dar un estacazo

            if (ds.LIBROS[0].IsFechaLecturaNull())
             {
                 dtpLectura.Checked = false;                
            }
             else
            {
               dtpLectura.Checked = true;
               this.dtpLectura.Value = ds.LIBROS[0].FechaLectura;
            }


            //-->Tratamiento de la imagen para mostrar las portadas 
            //------------------------------------------------------------------------------------------- 
            /*
               Vamos a pintar la imagen que tendremos guardada en la tabla de Libros,
               en el campo lo que tenemos es un  STREAM es decir una cadena que puede
               leer de un origen  como es una matriz en memoria, de un fichero en disco, etc..

               En nuestro caso se trata de una matriz de bytes la cual debemos de convertirla a una imagen
               Antes de pintar vamos a preguntar si es NULL que sino pega el estacazo                                            
             */

            if (! ds.LIBROS[0].IsPortadaNull())
            {
                var stream = new System.IO.MemoryStream(ds.LIBROS[0].Portada);
                pbxPortada.Image = System.Drawing.Bitmap.FromStream(stream); 
            }
        }

        
        //---->Este metodo lo habra pintado sin darme cuenta yo...relamente no es necesario ya estoy haciendo yo
        //     la carga arriba 
        private void frmEdicion_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'coleccionesDS.LIBROS'  Puede moverla o quitarla según sea necesario.
           //        this.lIBROSTableAdapter.Fill(this.coleccionesDS.LIBROS);

        }

        //->Metodo que captura el evento de cierre del formulario para hacer las grabaciones 
        private void frmEdicion_FormClosing(object sender, FormClosingEventArgs e)
        {
            //-->Movemos la información de los objetos del formulario al DataSet


            ds.LIBROS[0].Titulo = tbxTitulo.Text;   
            ds.LIBROS[0].Descripcion = tbxDescricion.Text;
            ds.LIBROS[0].FechaCompra = dtpCompra.Value ;

            //-->Para el campo Fecha Lectura, vamos a preguntar por el valor del check
            //   si estuviera marcado grabaremos la fecha  de lo contrario la dejaremos con 
            //   NULL  que indicará que el libro no ha sido leido.

            if ( dtpLectura.Checked)
            {
               ds.LIBROS[0].FechaLectura = dtpLectura.Value;   //En el video está indicando la fecha de Compra!!!!!
                
            }
            else
            {
                // puta mierda no se queda siempre  con el check  marcado
                ds.LIBROS[0].SetFechaLecturaNull();
                
            }


            //->Aqui vamos tratar la imagen
            //-----------------------------------------------------------------
            // Tenemos que volver a utilizar un STREAM 

          

            var fs = new System.IO.MemoryStream();   // OJO  OJO  el profe ha hecho aquí un truco para agregar la 
                                                     //           referencia a systemIO.
                                                     // Al escribir el  MemoryStream  sale una rallita debajo de la M
                                                     // Yo utilizo las sugerencias y lo pongo de esta forma 

            //->Hay que controlar que la imagen no sea NULL de lo contrario peta,

            if (pbxPortada.Image  == null)
            {
                MessageBox.Show("No hay imagen, no se guardara el dato" );
            }
            else
            {
                pbxPortada.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);  //Aqui guardamos en memoria
                                                                                     //el fichero seleccionado del formato jpeg
                                                                                     //que es el que permitimos cargar
                ds.LIBROS[0].Portada = fs.ToArray();    //STREAM es una cadena de bytes
            }



            //->Utilizamos el método Update de nuestro adaptador 
            taLibros.Update(ds.LIBROS);
        }



        //-->Metodo para capturar las imagenes, con el doble click sobre el mismo control del formulario  
        private void pbxPortada_DoubleClick(object sender, EventArgs e)
        {
            //->Utilizaremos la búsqueda de ficheros standard ya existente
            var dialogo = new OpenFileDialog();  //Porque   OpenFileDialog  abre por defecto  la carpeta de Documentos  y no otra??

            //Podemos indicar la extensión, por un nombre concreto de archivo 
            dialogo.Filter = "Imagenes(jpg)|*.jpg";    //El palote es el de la tecla del  1

            if (dialogo.ShowDialog() == System.Windows.Forms.DialogResult.OK)            
            {   //->Si el dialogo es  OK  un jpg tal como hemos filtrado lo cargamos en el control
                pbxPortada.Image = System.Drawing.Bitmap.FromFile(dialogo.FileName);
            }
        }


        






    }
}
