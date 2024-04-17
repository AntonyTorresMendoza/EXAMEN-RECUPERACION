using System;
using System.Linq;

using AccesoDatos.BDRUTADataSetTableAdapters;
using AccesoDatos;

namespace AccesoDatosLayer
{
    public class dalVenta
    {
        private VentasTableAdapter _ventasTableAdapter;

        public dalVenta()
        {
            _ventasTableAdapter = new VentasTableAdapter();
        }

        public CVenta SeleccionarVenta(int id)
        {
            var venta = _ventasTableAdapter.GetData().FirstOrDefault(v => v.ID == id);

            if (venta == null)
            {
                return null;
            }

            return new CVenta
            {
                id = venta.ID,
                idcliente = venta.IDCliente,
                idruta = venta.IDRuta,
                cantidadpersonas = venta.CantidadPersonas
            };
        }

        public void InsertarVenta(CVenta pVenta)
        {
            var nuevaVenta = _ventasTableAdapter.GetData().NewVentasRow();
            nuevaVenta.IDCliente = pVenta.idcliente;
            nuevaVenta.IDRuta = pVenta.idruta;
            nuevaVenta.CantidadPersonas = pVenta.cantidadpersonas;
            _ventasTableAdapter.GetData().AddVentasRow(nuevaVenta);
            _ventasTableAdapter.Update(nuevaVenta);
        }

        public void ActualizarVenta(CVenta pVenta)
        {
            var venta = _ventasTableAdapter.GetData().First(v => v.ID == pVenta.id);
            venta.IDCliente = pVenta.idcliente;
            venta.IDRuta = pVenta.idruta;
            venta.CantidadPersonas = pVenta.cantidadpersonas;
            _ventasTableAdapter.Update(venta);
        }

        public void EliminarVenta(int ID_Venta)
        {
            var venta = _ventasTableAdapter.GetData().First(v => v.ID == ID_Venta);
            _ventasTableAdapter.Delete(venta.ID, venta.IDCliente, venta.IDRuta, venta.CantidadPersonas);
        }
    }
}
