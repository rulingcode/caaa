using layer_0.x_app;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_x_app.z
{
    class upsert_setup : y_upsert_setup
    {
        protected async override void implement()
        {
            if (await z_db.general_x<m.app>().any(i => i.id == a_appid))
            {
                reply(new o() { a_error = error.no_exist });
                return;
            }
            var db = z_db.user<m.setup>(z_userid);
            if (a_degree == e_degree.non)
            {
                await db.delete(a_appid);
                await z_db.user<sync_app>(z_userid).delete(a_appid);
            }
            var setup = await db.get(z_userid);
            switch (a_degree)
            {
                case e_degree.non:
                    {

                    }
                    break;
                case e_degree.high:
                    {

                    }
                    break;
                case e_degree.medium:
                    {

                    }
                    break;
                case e_degree.low:
                    {

                    }
                    break;
            }
            await db.upsert(setup);

        }
    }
}