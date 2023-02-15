using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Hotelaria
{
    public class Serializador
    {
        public static void EncheLista(ref List<Funcionarios> listaRetorno, string caminho)
        {
            if (File.Exists(caminho))
            {
                XmlSerializer leitor = new XmlSerializer(typeof(List<Funcionarios>));
                StreamReader sr = new StreamReader(caminho);
                List<Funcionarios> listaTemp = (List<Funcionarios>)leitor.Deserialize(sr);
                sr.Close();
                listaRetorno = listaTemp;
            }
            else
                listaRetorno = new List<Funcionarios>();
        }

        public static void EncheLista(ref List<Reservas> listaRetorno, string caminho)
        {
            if (File.Exists(caminho))
            {
                XmlSerializer leitor = new XmlSerializer(typeof(List<Reservas>));
                StreamReader sr = new StreamReader(caminho);
                List<Reservas> listaTemp = (List<Reservas>)leitor.Deserialize(sr);
                sr.Close();
                listaRetorno = listaTemp;
            }
            else
                listaRetorno = new List<Reservas>();
        }
        public static void Serializa(List<Funcionarios> listaFuncionarios, string caminho)
        {
            XmlSerializer escritor = new XmlSerializer(typeof(List<Funcionarios>));

            if (File.Exists(caminho))
            {
                FileStream fs = File.Open(caminho, FileMode.Open);
                escritor.Serialize(fs, listaFuncionarios);
                fs.Close();
            }
            else
            {
                FileStream fs = File.Create(caminho);
                escritor.Serialize(fs, listaFuncionarios);
                fs.Close();
            }
        }
        public static void Serializa(List<Reservas> listaReservas, string caminho)
        {
            XmlSerializer escritor = new XmlSerializer(typeof(List<Reservas>));

            if (File.Exists(caminho))
            {
                FileStream fs = File.Open(caminho, FileMode.Open);
                escritor.Serialize(fs, listaReservas);
                fs.Close();
            }
            else
            {
                FileStream fs = File.Create(caminho);
                escritor.Serialize(fs, listaReservas);
                fs.Close();
            }
        }

        public static void Recria(List<Reservas> listaReservas, string caminho)
        {
            XmlSerializer escritor = new XmlSerializer(typeof(List<Reservas>));
            FileStream fs = File.Create(caminho);
            escritor.Serialize(fs, listaReservas);
            fs.Close();
        }
    }
}
