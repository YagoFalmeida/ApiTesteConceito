namespace ApiTesteConceito.Dominio.Modelagens.MercadoFinanceiro
{
    public class FundoImobiliario
    {
        public long Id { get; set; }
        public string Sigla { get; set; }
        public string NomeAdministrador { get; set; }

        public FundoImobiliario()
        {
            Sigla = string.Empty;
            NomeAdministrador = string.Empty;
        }
    }
}
