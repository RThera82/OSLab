using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            String path = "Informations2.json";
            /*Human one = new Human("Alex","Jackson","180","A+","70");
            Human two = new Human("John","Johnson","177","O-","80");
            Human three = new Human("Nicole","Watson","168","AB+","50");
            File.WriteAllText("Informations2.json","fname:" +one.fname);
            File.AppendAllText("Informations2.json","\nlname:"+one.lname);
            File.AppendAllText("Informations2.json", "\nheight:"+one.height);
            File.AppendAllText("Informations2.json", "\nbloodtype:"+one.bloodtype);
            File.AppendAllText("Informations2.json", "\nweight:"+one.weight);
            File.AppendAllText("Informations2.json", "\nfname:"+two.fname);
            File.AppendAllText("Informations2.json", "\nlname:" + two.lname);
            File.AppendAllText("Informations2.json", "\nheight:" + two.height);
            File.AppendAllText("Informations2.json", "\nbloodtype:" + two.bloodtype);
            File.AppendAllText("Informations2.json", "\nweight:" + two.weight);
            File.AppendAllText("Informations2.json", "\nfname:" + three.fname);
            File.AppendAllText("Informations2.json", "\nlname:" + three.lname);
            File.AppendAllText("Informations2.json", "\nheight:" + three.height);
            File.AppendAllText("Informations2.json", "\nbloodtype:" + three.bloodtype);
            File.AppendAllText("Informations2.json", "\nweight:" + three.weight);*/
            String filecontent = File.ReadAllText("Informations2.json");
            var jsonobject= JsonConvert.DeserializeObject(filecontent);
            string json = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
            File.WriteAllText("Informations2.json", json);
            String line;
            using (StreamReader reader = new StreamReader("Informations2.json"))
            {
                while ((line = reader.ReadLine()) != null)
                    Console.WriteLine(line);
                    
            }
            Console.ReadKey();
        }
        struct Human
        {
            public String fname;
            public String lname;
            public String height;
            public String bloodtype;
            public String weight;
            public Human(String fname,String lname,String height,String bloodtype,String weight)
            {
                this.fname = fname;
                this.lname = lname;
                this.height = height;
                this.bloodtype = bloodtype;
                this.weight = weight;
            }
        }

    }
}
