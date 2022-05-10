using AppElevator.Domain.Service;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace AppElevator.Infra.Data
{
    //Aqui leio o arquivo setado e envio os dados do arquivo
    //Para um objeto json para ser trabalhado

    public class ReadJsonData : IRepositoryData            
    {

        private JArray jsonaArray;

        private IRepositoryData _RepositoryData { get; set; }

        public ReadJsonData() { }

        public ReadJsonData( string filepath )
        {
            try
            {
                using (var reader = File.OpenText(filepath))
                {
                    this.jsonaArray = JArray.Parse(reader.ReadToEnd());
                }
            }
            catch (Exception ex)
            {
                throw new Exception( ex.Message );  
            }
        }

        
        public ReadJsonData( IRepositoryData repositoryData)
        {
             _RepositoryData = repositoryData;
        }

        public JArray GetData()
        {           
            return this.jsonaArray;
        }       
    }

}
