using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TesteBack
{
    class dal
    {
        conection con = new conection();
        private MySqlCommand command;
        private MySqlDataReader infos;

        public void add_customer(custumer people)
        {
            try
            {
                con.connect();
                string query = "INSERT INTO tb_customer_account(cpf_cnpj,nm_customer,is_active,vl_total)VALUES('" + people.cpf_cnpj + "','" + people.nm_customer + "'," + people.is_active + "," + people.vl_total + ")";
                command = new MySqlCommand(query, con.connection);
                command.ExecuteNonQuery();
                con.disconnect();
                
            }
            catch(Exception excep)
            {
                throw new Exception("Erro de comandos!\n" + excep.Message);
            }

            

        }


        public List<custumer> consult_customer()
        {
            List<custumer> peoples = new List<custumer>();
            
            try
            {
                con.connect();
                string query = "SELECT `nm_customer`,`cpf_cnpj`, `is_active`, `vl_total` FROM `tb_customer_account` WHERE id_customer > 1500 and id_customer < 2700 and vl_total >560 ORDER BY vl_total DESC ";
                command = new MySqlCommand(query, con.connection);
                infos = command.ExecuteReader();

                while (infos.Read())
                {
                    custumer user = new custumer();
                    user.nm_customer = infos["nm_customer"].ToString();
                    user.cpf_cnpj = infos["cpf_cnpj"].ToString();
                    user.is_active = Convert.ToInt32(infos["is_active"]);
                    user.vl_total = Convert.ToInt32(infos["vl_total"]);

                    peoples.Add(user);
                }
                con.disconnect();
                return peoples;
            }
            catch (Exception excep)
            {
                throw new Exception("Erro de comandos!\n" + excep.Message);
            }
            
        }
    }
}
