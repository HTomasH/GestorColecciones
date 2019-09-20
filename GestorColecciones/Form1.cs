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
        //->Este metodo se crea al seleccionar en las propiedades del Formulario el EEVENTO(rayo) FromClosing        
        private void frmCatalogo_FormClosing(object sender, FormClosingEventArgs e)
        {
            lIBROSTableAdapter.Update(coleccionesDS.LIBROS);

        }

        //-->Desde las propiedades del DataGrid, creamos este metodo del EVENTO  CellDoubleClick
        //   para que al hacer el dobleClic  nos abra un formulario.
        //
        //  NOTA-2 : OjO este evento es el dobleclic en el DataGrid, si lo que queremos tratar es el contenido
        //           de la celda en cuestion sería el evento  CellContentDoubleClick
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //-->Vamos a pillar el registro(vía indice) que guardaremos en la variable 'libro'
            //   del libro en el cual hayamos hecho el dobleClick en el DataGrid
            //
            //   Este metodo de selección es básicamente una MIERDA,  si se reordena el DataGrid
            //   el indice segira apuntando al primer registro y claro no se corresponde con el 
            //   dato que se muestra despues de la reordenación en el DataGrid 
            //var libro = coleccionesDS.LIBROS[e.RowIndex];
            //MessageBox.Show(libro.Descripcion);

            //-->Vamos a pillar el registro por su ID, que es lo mejor, para lo cual
            //   vamos a volver a incluirlo en el DataGrid pero dejándolo  invisible para que no se vea 
            //
            //   Estamos pillando el IdLibro que sabemos que es un campo int,  como el valor devuelto es obj, pues lo convertimos
            //   Estamos pilland el valor de la celda cero 0  donde esta el campo IdLibro  
            int idLibro = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            MessageBox.Show(idLibro.ToString());






        }
    }
}
