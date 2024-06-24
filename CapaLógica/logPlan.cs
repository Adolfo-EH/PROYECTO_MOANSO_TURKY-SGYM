using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLógica
{
    public class logPlan
    {
        #region singleton
        private static readonly logPlan _instancia = new logPlan();
        //privado para evitar la instanciación directa
        public static logPlan Instancia
        {
            get
            {
                return logPlan._instancia;
            }
        }
        #endregion singleton
        #region metodos
        ///listado
        public List<entPlan> ListarPlan()
        {
            return datPlan.Instancia.ListarPlan();
        }
        ///inserta
        public void InsertaPlan(entPlan pl)
        {
            datPlan.Instancia.InsertarPlan(pl);
        }
        //edita
        public void HabilitarPlan(entPlan pl)
        {
            datPlan.Instancia.HabilitarPlan(pl);
        }

        public void DeshabilitarPlan(entPlan pl)
        {
            datPlan.Instancia.DeshabilitarPlan(pl);
        }
        #endregion metodos
    }
}
