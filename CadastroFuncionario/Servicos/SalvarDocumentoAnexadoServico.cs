using System;
using System.IO;
using System.Web;

namespace CadastroFuncionario.Servicos
{
    public class SalvarDocumentoAnexadoServico
    {
        public SalvarDocumentoAnexadoServico(HttpPostedFile documento)
        {
            Documento = documento;
            string extensaoDocumento = Path.GetExtension(documento.FileName);
            string nomeDocumentoSemExtensao = Path.GetFileNameWithoutExtension(documento.FileName);
            NomeDocumento = $"{nomeDocumentoSemExtensao}-{Guid.NewGuid()}{extensaoDocumento}";
        }

        public string NomeDocumento { get; private set; }
        public HttpPostedFile Documento { get; private set; }

        public void SalvarDocumento(string raizDoCaminhoDestino)
        {
            string caminhoParaSalvar = Path.Combine(raizDoCaminhoDestino, NomeDocumento);
            Directory.CreateDirectory(raizDoCaminhoDestino);
            Documento.SaveAs(caminhoParaSalvar);
        }
    }
}