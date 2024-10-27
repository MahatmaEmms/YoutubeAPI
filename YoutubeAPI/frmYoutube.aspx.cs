using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using BLL;

namespace YoutubeAPI
{
    public partial class frmYoutube : System.Web.UI.Page
    {
        protected async void btnBuscar_Click(object sender, EventArgs e)
        {
            string query = txtBuscar.Text;
            ///HEAD

            // Guardar la búsqueda en la base de datos
            SQLDBHelper busquedasDAL = new SQLDBHelper();
            busquedasDAL.GuardarBusqueda(query); // Asegúrate de que el método recibe 'query' y lo inserta como 'informacion'

            // 6b43d48803df3bc503f96e4812b56a09cee8f9f7
            BDYoutube_DAL youtubeDAL = new BDYoutube_DAL();
            List<BDYoutube_BLL> videos = await youtubeDAL.BuscarVideos(query);
            rptVideos.DataSource = videos;
            rptVideos.DataBind();
        }
        //HEAD

        //6b43d48803df3bc503f96e4812b56a09cee8f9f7
    }
}