using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TesteBack
{
    public partial class Form1 : Form
    {

        custumer people;
        dal da;

        massive_add generator;
        List<custumer> peoples = new List<custumer>();


        public Form1()
        {
            InitializeComponent();
            people = new custumer();
            da= new dal();
            generator = new massive_add();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            people.nm_customer = tb_name.Text;
            people.cpf_cnpj = tb_cpf.Text;
            people.vl_total = Convert.ToInt32(tb_value.Text);

            //Se 1 ativo, se 0 inativo

            if (activit_true.Checked == true)
                people.is_active = 1;
            else
                people.is_active = 0;

            //insere
            da.add_customer(people);

            //limpa os campos

            tb_name.Text = "";
            tb_cpf.Text = "";
            tb_value.Text = "";
            activit_true.Checked = true;



        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            peoples = da.consult_customer();
            int count= 0;
            string n = "";
            for (int i = 1; i < peoples.Count; i++)
                {
                n = "NOME: " + peoples[i].nm_customer + " ";
                n += "CPF/CNPJ: " + peoples[i].cpf_cnpj + " ";
                n += "VALOR: " + peoples[i].vl_total + " ";

                if(peoples[i].is_active == 1)
                    n += "Ativo:" + " Sim";
                else
                    n += "Ativo:" + " Não";

                lb_select.Items.Add(n);
                count += peoples[i].vl_total;
            }
            lb_média.Text = "Média da consulta" + count / peoples.Count();
        }
        //------------------------------------------------------------------------


        //Cria automaticamente 3000 custumers para o DataBase
        private void btn_massive_add_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 1; i <= 3000; i++)
            {
                people.nm_customer = generator.name();
                people.cpf_cnpj = "222.222.222-22";
                people.vl_total = r.Next(1, 3000);

                if (r.Next(10) > 4)
                    people.is_active = 1;
                else
                    people.is_active = 0;


                da.add_customer(people);
                Thread.Sleep(500);
            }
            
        }

        
    }
}
