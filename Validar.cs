using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Documentos
{
    class Validar
    {
        public static void NumerosYPunto(KeyPressEventArgs v)
        {
            if(Char.IsDigit(v.KeyChar) || Char.IsControl(v.KeyChar) || v.KeyChar.ToString().Equals("."))
            {
                v.Handled = false;
            }
            else
            {               
                v.Handled = true;
            }
        }

        public static void NumerosYPuntoSinEspacio(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar) || Char.IsControl(v.KeyChar) || v.KeyChar.ToString().Equals("."))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
            }
        }

        public static void NumerosEnteros(KeyPressEventArgs v)
        {
            if(Char.IsDigit(v.KeyChar) || Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {               
                v.Handled = true;
            }
        }
    }
}
