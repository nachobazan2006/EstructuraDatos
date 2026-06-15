using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pryEDBazanI.Clases;

namespace pryEDBazanI.Formularios
{
    public partial class frmOperaciones : Form
    {
        public frmOperaciones()
        {
            InitializeComponent();
        }

        private void EjecutarConsulta(String consulta)
        {
            clsBaseDatos objBaseDatos = new clsBaseDatos();
            objBaseDatos.Listar(dgvBaseDatos, consulta);
        }

        private void btnProyeccionSimple_Click(object sender, EventArgs e)
        {
            EjecutarConsulta("SELECT Titulo FROM Libro");
        }

        private void btnProyeccionMultiatributo_Click(object sender, EventArgs e)
        {
            EjecutarConsulta("SELECT Titulo, Año, Precio FROM Libro");
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            EjecutarConsulta("SELECT Libro.Titulo, Autor.Nombre AS Autor, Pais.Nombre AS Pais, Idioma.Nombre AS Idioma " +
                "FROM ((Libro INNER JOIN Autor ON Libro.IdAutor = Autor.IdAutor) " +
                "INNER JOIN Pais ON Libro.IdPais = Pais.IdPais) " +
                "INNER JOIN Idioma ON Libro.IdIdioma = Idioma.IdIdioma");
        }

        private void btnSeleccionSimple_Click(object sender, EventArgs e)
        {
            EjecutarConsulta("SELECT * FROM Libro WHERE Precio > 500");
        }

        private void btnSeleccionMultiatributo_Click(object sender, EventArgs e)
        {
            EjecutarConsulta("SELECT * FROM Libro WHERE Precio > 500 AND Cantidad > 5");
        }

        private void btnSeleccionPorConvolucion_Click(object sender, EventArgs e)
        {
            EjecutarConsulta("SELECT * FROM Libro WHERE Titulo LIKE 'A%'");
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            EjecutarConsulta("SELECT Titulo FROM Libro WHERE Precio > 700 " +
                "UNION SELECT Titulo FROM Libro WHERE Cantidad > 5");
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            EjecutarConsulta("SELECT A.Titulo " +
                "FROM (SELECT Titulo FROM Libro WHERE Precio > 500) AS A " +
                "INNER JOIN (SELECT Titulo FROM Libro WHERE Cantidad > 5) AS B " +
                "ON A.Titulo = B.Titulo");
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            EjecutarConsulta("SELECT A.Titulo " +
                "FROM (SELECT Titulo FROM Libro WHERE Precio > 500) AS A " +
                "LEFT JOIN (SELECT Titulo FROM Libro WHERE Cantidad > 5) AS B " +
                "ON A.Titulo = B.Titulo " +
                "WHERE B.Titulo IS NULL");
        }
    }
}
