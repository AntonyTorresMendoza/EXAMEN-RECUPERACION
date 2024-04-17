using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class VentaBL
    {
        public string RegistrarVenta(AccesoDatos.CVenta venta)
        {
            try
            {
                if (venta.id <= 0 || venta.idcliente <= 0 || venta.idruta <= 0 || venta.cantidadpersonas <= 0)
                {
                    return "Error: Todos los campos deben ser positivos y mayores a cero.";
                }
                else if (venta.cantidadpersonas > 60)
                {
                    return "Error: La cantidad de personas no puede exceder de 60.";
                }
                else
                {
                
                    return $"Venta registrada con éxito: {venta.ToString()}";
                }
            }
            catch (Exception ex)
            {
                return $"Error al registrar la venta: {ex.Message}";
            }
        }
    }
}
