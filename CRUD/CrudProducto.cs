using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    class CrudProducto
    {
        private Producto[] _productos;
        private int _cantidad;

        public CrudProducto()
        {
            _productos = new Producto[15];
            _cantidad = 0;
        }

        public void Agregar(Producto producto)
        {
            if(_cantidad < _productos.Length)  //Comprueba si el vector aún tiene espacio.
            {
                _productos[_cantidad] = producto;
                _cantidad++;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Vector lleno.");
            }
        }

        public Producto Buscar(int codigo)
        {
            for (int i = 0; i < 15; i++)
            {
                if(_productos[i].Codigo == codigo)
                {
                    return _productos[i];
                }
            }
            return null;
        }

        public void Insertar(Producto producto, int posicion)
        {
            Recorrer(posicion);
            _productos[posicion] = producto;
            _cantidad++;
        }

        private void Recorrer(int posicion) 
        {
            /*Recorre a la derecha*/
            for (int i = 14; i > posicion; i--)
            {
                _productos[i] = _productos[i - 1];
            }
            
        }

        public void Eliminar(int codigo)
        {
            //Ciclo para encontrar el elemento a eliminar
            for (int i = 0; i < 15; i++)
            {
                if(_productos[i].Codigo == codigo)
                {
                    _productos[i] = null;
                }
            }
        }

        public string Listar()
        {
            string lista = "LISTA DE PRODUCTOS" + Environment.NewLine;

            if (_cantidad != 0)
            {
                for (int i = 0; i < _cantidad; i++)
                {
                    lista += _productos[i].ToString() + Environment.NewLine;
                }
            }
            return lista;
        }
    }
}
