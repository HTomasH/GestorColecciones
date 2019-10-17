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
    public partial class frmEstado : Form
    {

        //->Vamos a cargar todos los datos asociados al idlibro  que nos llega  
        int idLibro;

        //->Vamos a instanciar los Adapter para pillar los datos correspondientes
        //-----------------------------------------------------------------------
        
        //->Para las Personas 
        ColeccionesDSTableAdapters.PersonasTableAdapter taPersonas = new ColeccionesDSTableAdapters.PersonasTableAdapter();

        //->Para las Pretamos 
        ColeccionesDSTableAdapters.PrestamosTableAdapter taPrestamos = new ColeccionesDSTableAdapters.PrestamosTableAdapter();

        //-> Utilizamos  la variable prestamos para utilizarla como el alias de la tabla de los Prestamos 
        ColeccionesDS.PrestamosDataTable prestamos;  


        //Este es el constructor... podemos o no inicializar valores... 
        //en este caso  SI,  que acepte el valor del  idLibro
        public frmEstado( int idLibro )
        {                                           
            //->OjO  que este es la instrucción para activar los controles del formulario
            InitializeComponent();


            //Como no estaba poniendo esta linea NO me conservaba el valor del idLibro que traia del Grid.
            this.idLibro = idLibro;
        }


        private void frmEstado_Load(object sender, EventArgs e  )
        {
            var personas =  taPersonas.GetData();  //->Cargamos en una variable  la tabla con los datos que utilizaremos en el ComboBox 
            cbxPersona.DataSource = personas;   //Le decimos el orgigen de losdatos 
            cbxPersona.DisplayMember = "Nombre";    //Indica que campo de la tabla personas queremos mostrar 
            cbxPersona.ValueMember = "IdPersona";      //Este será el valor realmente seleccionado 


            //->Ahora vamos a cargar el ULTIMO préstamo 
            prestamos = taPrestamos.GetDataByLast(idLibro); 



            if(prestamos == null  || prestamos.Count == 0)  //Si fuera NULL o nunca se ha prestado  COUNT  a cero 
            { //No se ha prestado en la puta vida 
                dtpDevolucion.Checked = false;
                dtpPrestado.Checked = false;
            }
            else
            { //Sí se ha prestado
             //Aunque sabemos que en esta seleción solo viene un registro ya que en el FillBitLast  indicamos TOP(1)
             //debemos de indicar  el  valor  [0]  eligiendo explicitamente la primera fila....
             
                if (prestamos[0].IsFechaNull())
                {   //El libro sigue prestado
                    dtpDevolucion.Checked = false;                     
                }
                else
                {   //Ya se ha devuelto
                    dtpDevolucion.Checked = true;      //Check marcado como que esta prestado 
                    dtpDevolucion.Value = prestamos[0].FechaDevolucion;   //La fecha en la que fue prestado   esto es FechaPrestamo 
                }
                dtpDevolucion.Checked = true;      //Check marcado como que esta prestado 
                dtpDevolucion.Value = prestamos[0].Fecha;   //La fecha en la que fue prestado 
                cbxPersona.SelectedValue = prestamos[0].FkPersona;  // Al fulano que se lo hemos prestado 
            }


        }

        // LOGICA DEL BOTON ACEPTAR 

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            //La principal es que si no esta marcado el check de que se va a realizar un prestamo  entonces no hacemos nada 
            if (dtpPrestado.Checked)
            {


                if (prestamos == null || prestamos.Count == 0)  //Si fuera NULL o nunca se ha prestado  COUNT  a cero             
                {
                    //No se ha prestado

                    //-->Preparamos alta de nuevo registro en el dataset
                    var nuevo = prestamos.NewPrestamosRow();    


                    nuevo.FkLibro = idLibro; //NO LE MOLA ESTE VALOR  TIENE CERO....
                    nuevo.FkPersona = (int)cbxPersona.SelectedValue; //El valor del fulano que tenemos seleccionado en el ComboBox

                    if (dtpDevolucion.Checked)
                    {
                        nuevo.FechaDevolucion = dtpDevolucion.Value;
                    }
                    else
                    {
                        nuevo.SetFechaDevolucionNull();
                    }

                    //->Añadimos el nuevo registro al DataSet
                    prestamos.AddPrestamosRow(nuevo);

                }
                else
                {  //Sí se ha prestado, hay que actualizar los datos 

                    //Recordar del curso que las tablas devuelven OBJ así que hay que hacer la conversion adecuada
                    prestamos[0].FkPersona = (int)cbxPersona.SelectedValue;   
                    if (dtpDevolucion.Checked)
                    {
                        prestamos[0].FechaDevolucion = dtpDevolucion.Value;
                    }
                    else
                    {
                        prestamos[0].SetFechaDevolucionNull();
                    }
                }

                //Actualizar la tabla   y cerramos el formulario
                taPrestamos.Update(prestamos);
                Close();
            }             
            else
            { 
                MessageBox.Show("No se ha marcado el CHECK de prestar así que nos salimos ");
                Close();   //Estariamos cerrado el formulario 
            }
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
 }

