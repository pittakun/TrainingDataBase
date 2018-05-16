using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteBack
{
    class massive_add
    {

        //Classe usada pra criar varios cadastros automaticamente.
        private List<string> first_name= new List<string>();
        private List<string> second_name = new List<string>();
        private List<string> thirt_name = new List<string>();

        public massive_add()
        {
            first_name.Add("Adriano");
            first_name.Add("Beto");
            first_name.Add("Ana");
            first_name.Add("Candido");
            first_name.Add("Gabriel");
            first_name.Add("Elise");
            first_name.Add("Diana");
            first_name.Add("Luna");
            first_name.Add("Belardo");
            first_name.Add("Pablo");
            first_name.Add("Gêni");
            first_name.Add("Anabel");
            first_name.Add("Carolina");
            first_name.Add("Biel");
            first_name.Add("Sander");
            first_name.Add("Katarina");
            first_name.Add("Luma");
            first_name.Add("Claudia");
            first_name.Add("Alessandra");
            first_name.Add("Giovane");


            second_name.Add("Menezes");
            second_name.Add("Almeida");
            second_name.Add("Cabral");
            second_name.Add("Oliveira");
            second_name.Add("Rosa");
            second_name.Add("Queiroz");
            second_name.Add("Lefrev");
            second_name.Add("Tobias");
            second_name.Add("Maria");
            second_name.Add("Técio");
            second_name.Add("Carvalho");


            thirt_name.Add("de Pedralva");
            thirt_name.Add("Albanio");
            thirt_name.Add("Silva");
            thirt_name.Add("da Silva");
            thirt_name.Add("Irineu");
            thirt_name.Add("Bitencourt");
            thirt_name.Add("Araujo");
            thirt_name.Add("de Araujo");
            thirt_name.Add("Manoâ");
            thirt_name.Add("Pedreira");
            

        }

        public string name()
        {
            string n;
            Random r1 = new Random();
            Random r2 = new Random();
            Random r3 = new Random();


            n = first_name[r1.Next(20)] + " " + second_name[r2.Next(10)];

            if(r3.Next(2)+1 == 2)
            {
                n += " " + thirt_name[r3.Next(10)];
            }

            return n;
        }
    }
}
