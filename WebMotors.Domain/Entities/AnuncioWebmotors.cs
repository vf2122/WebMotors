namespace WebMotors.Domain.Entities
{
    public class AnuncioWebmotors : Entity
    {
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public string Versao { get; private set; }
        public int Ano { get; private set; }
        public int Quilometragem { get; private set; }
        public string Observacao { get; private set; }

        // EF
        public AnuncioWebmotors()
        {
        }

        public AnuncioWebmotors(string Marca, string Modelo, string Versao, int Ano, int Quilometragem, string Observacao)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Versao = Versao;
            this.Ano = Ano;
            this.Quilometragem = Quilometragem;
            this.Observacao = Observacao;

            //new AddNotifications<AnuncioWebmotors>(this)
            //    .IfNullOrInvalidLength(x => x.Marca, 3, 45)
            //    .IfNullOrInvalidLength(x => x.Modelo, 3, 45)
            //    .IfNullOrInvalidLength(x => x.Versao, 3, 45)
            //    .IfTrue(x => x.Ano > 1900, "Digite um ano válido. Ex: 1994")
            //    .IfNull(x => x.Ano)
            //    .IfNull(x => x.Quilometragem)
            //    .IfTrue(x => !string.IsNullOrEmpty(x.Observacao) && x.Observacao.Length < 15);
        }

        public void SetMarca(string marca)
        {
            this.Marca = marca;
        }

        public void SetModelo(string modelo)
        {
            this.Modelo = modelo;
        }

        public void SetVersao(string versao)
        {
            this.Versao = versao;
        }

        public void SetAno(int ano)
        {
            this.Ano = ano;
        }

        public void SetQuilometragem(int quilometragem)
        {
            this.Quilometragem = quilometragem;
        }

        public void SetObservacao(string observacao)
        {
            this.Observacao = observacao;
        }

    }
}
