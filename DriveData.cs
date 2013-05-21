using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace DriveCatalog
{
    /// <summary>
    /// Estrutura serializável para informações que contém chave/valor.
    /// </summary>
    /// <typeparam name="K">Chave</typeparam>
    /// <typeparam name="V">Valor</typeparam>
    [Serializable]
    public struct ChaveValorSer<C, V>
    {
        private C size;
        private V file;
        [XmlAttribute]
        public C Size { get { return size; } set { size = value; } }
        [XmlAttribute]
        public V File { get { return file; } set { file = value; } }
    }
    
    public class DriveData
    {
        private string _identificador;
        
        /// <summary>
        /// Código string do drive.
        /// </summary>
        [XmlAttribute]
        public string Identificador
        {
            get { return _identificador; }
            set { _identificador = value; }
        }

        private List<ChaveValorSer<string, string>> _diretoriosArquivos;

        /// <summary>
        /// Diretório mais o arquivo.
        /// </summary>
        [XmlElement]
        public List<ChaveValorSer<string, string>> File
        {
            get { return _diretoriosArquivos; }
            set { _diretoriosArquivos = value; }
        }

        private string _data;

        /// <summary>
        /// Data.
        /// </summary>
        [XmlAttribute]
        public string Data
        {
            get { return _data; }
            set { _data = value; }
        }

        private string _tipoArquivos;

        /// <summary>
        /// Tipo de Arquivos.
        /// </summary>
        [XmlAttribute]
        public string TipoArquivos
        {
            get { return _tipoArquivos; }
            set { _tipoArquivos = value; }
        }

    }
}
