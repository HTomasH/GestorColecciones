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
    public partial class frmCatalogo : Form
    {
        public frmCatalogo()
        {
            InitializeComponent();
        }

        //-->Carga el catalogo 
        private void frmCatalogo_Load(object sender, EventArgs e)
        {


            // TODO: esta línea de código carga datos en la tabla 'coleccionesDS.LIBROS' Puede moverla o quitarla según sea necesario.
            //       Está rellenando(FILL) el adaptador  con los datos de la tabla LIBROS
            this.lIBROSTableAdapter.Fill(this.coleccionesDS.LIBROS);

            //-->Como de momento no tenemos un boton de guardado, 
            //   vamos a forzar la grabación en la BB.DD cuando se cierre 
            //   el formulario a traves de la propiedades del formulario. 

            //NOTA-1 : Cuando añadimos los datos el ID se muestra en negativo esto es porque estamos
            //         en el DataSet y es un valor temporal, cuando lo pasemos a la tabla de la BB.DD ya tomará
            //         el valor adecuado.
        }

        //-->En este metodo volcamos los datos a la tabla indicada 
        // 
        //->Este metodo se crea al seleccionar en las propiedades del Formulario el EVENTO(rayo) FromClosing        
        private void frmCatalogo_FormClosing(object sender, FormClosingEventArgs e)
        {
            lIBROSTableAdapter.Update(coleccionesDS.LIBROS);

        }

        //-->Desde las propiedades del DataGrid, creamos este metodo del EVENTO  CellDoubleClick
        //   para que al hacer el dobleClic  nos abra un formulario.
        //
        //  NOTA-2 : OjO este evento es el dobleclic en el DataGrid, si lo que queremos tratar es el contenido
        //           de la celda  donde hagamos el clcik en cuestion sería el evento  CellContentDoubleClick
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //-->Vamos a pillar el registro(vía indice) ES UNA MIERDA  lo que hay que utilizar es el campo IDlibro que guardaremos en la variable 'libro'
            //   del libro en el cual hayamos hecho el dobleClick en el DataGrid
            //
            //   Este metodo de selección es básicamente una MIERDA,  si se reordena el DataGrid
            //   el indice segira apuntando al primer registro y claro no se corresponde con el 
            //   dato que se muestra despues de la reordenación en el DataGrid 
            //
            //var libro = coleccionesDS.LIBROS[e.RowIndex];
            //MessageBox.Show(libro.Descripcion);

            //-->Vamos a pillar el registro por su ID, que es lo mejor, para lo cual
            //   vamos a volver a incluirlo en el DataGrid pero dejándolo  invisible para que no se vea 
            //
            //   Estamos pillando el IdLibro que sabemos que es un campo int,  como el valor devuelto es obj, pues lo convertimos
            //   Estamos pilland el valor de la celda cero 0  donde esta el campo IdLibro  
            int idLibro = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            MessageBox.Show("Este es el valor del idlibro : " + idLibro.ToString());
            VerDetalle(idLibro);
            
            
        }


        //->> OPCION DE MENU CONTEXTUAL  NO TIENE LINEA FIJA, APARECE AL DAR AL BOTON DERECHO DEL RATON 
        private void tsmLIBRO_Click(object sender, EventArgs e)
        {

            //->PILLAMOS el idlibro del Grid  de la fila seleccionada,  hacemos el cast para int 
            //           OjO aquí daba error el  (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;  
            //           por el  SelectedCells  

            // TRUCO  :  Cuando nos da el error podemos selecionar ese linea o parte de ella y al pulsar el botón derecho 
            //           del ratón ir a la opcion  [Agregar inspección]   para ver que pasa al detalle 

            int idlibro = (int)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value;
            VerDetalle(idlibro);            
        }


        
        // REFACTORIZACION 
        // ----------------
        //
        // Metodo para el DobleClic de la opción del menú contextual 
        // Vamos a refactorizarlo 
        // En principio lo que va hacer es lo mismo que dobleClic del Grid 
        
        //*****************************************************************************************************
        //->Metodo creado a  partir de la opción [Acciones Rápidas y refactorizacion]  
        //  se obtiene seleccionado el código y pulsando la tecla izq. del ratón
        //
        //  Nos va a valer para pintar el detalle bien sea llamado desde el Grid o desde la opción del Menu
        //*****************************************************************************************************
        private void VerDetalle(int idlibro)
        {

            //-->Pintamos el formulario de detalle 
            //  (new frmEdicion(idlibro)).Show();
            new frmEdicion(idlibro).Show();

        }



        //->> OPCION DE MENU 
        private void tsmPRESTAMO_Click(object sender, EventArgs e)
        {

            //int idLibro = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            //->vamos a pillar el idlibro del Grid  de la fila seleccionada,  hacemos el cast para int 

            //->Con esta linea nos va a dar un error de que el indice esta fuera de rango, el profesor lo hace
            // para hacer un práctica de depuración para ver como podemos seleccionar una parte de codigo para inspeccionar a traves
            // del botón derecho del ratón  probar otras opciones ver que tengan o no informacion y con un copi/paste pegarlo en el 
            // código principal y seguir adelante

            // Linea 'mala' :   int idlibro = (int)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value;
            // esta fucionaria bien si hubieramos seleccionado una fila, pero no lo hemos hecho, entonces lo que necesitamos 
            // es el valor de la Celda 

            int idlibro = (int)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value;

            new frmEstado(idlibro).Show();

        }
    }
}
