using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SharkBank_App.Telas
{
    public static class EscreverArquivo
    {
        public static void EscreverChaves(string ChaveAleatoria, string Boleto, string QRCode, string Dono)
        {
            DirectoryInfo Diretorio = new DirectoryInfo(@"C:\SharkBank\Usuario");
            Diretorio.Create();
            DirectoryInfo DiretorioUser = Diretorio.CreateSubdirectory("User_" + Dono);
            DirectoryInfo DiretorioUserChave = DiretorioUser.CreateSubdirectory("Chaves");
            DirectoryInfo DiretorioUserTransacao = DiretorioUser.CreateSubdirectory("Transacao");
            DirectoryInfo DiretorioUserCartao = DiretorioUser.CreateSubdirectory("Cartao");

            // Chave

            StreamWriter SwChave = new StreamWriter(@"C:\SharkBank\Usuario\User_" + Dono + @"\"+ @"Chaves\"+ Dono + ".txt");
            SwChave.WriteLine("Chave Aletória: " + ChaveAleatoria);
            SwChave.WriteLine("QRCode: " + QRCode);
            SwChave.WriteLine("Boleto: " + Boleto);

            SwChave.Close();
        }

        public static void EscreverTransacao(int IDTransacao, string Dono, string Chave, string TipoTransacao,double Valor, string Data)
        {
            // Transacao

            StreamWriter SwTransacao = new StreamWriter(@"C:\SharkBank\Usuario\User_" + Dono + @"\" + @"Transacao\" + "Transacao_" + IDTransacao + ".txt");
            SwTransacao.WriteLine("ID Transação: " + Convert.ToString(IDTransacao));
            SwTransacao.WriteLine("Conta usada: " + Dono);
            SwTransacao.WriteLine("Chave transferida: " + Chave);
            SwTransacao.WriteLine("Tipo de transação: " + TipoTransacao);
            SwTransacao.WriteLine("Valor da transação: R$ " + Convert.ToString(Valor));
            SwTransacao.WriteLine("Data da transação: " + Data);

            SwTransacao.Close();
        }

        public static void EscreverCartao(int NumCartao, string CVV, string Validade, string Dono)
        {
            // Transacao

            StreamWriter SwTransacao = new StreamWriter(@"C:\SharkBank\Usuario\User_" + Dono + @"\" + @"Cartao\" + "Cartao_" + Dono + ".txt");
            SwTransacao.WriteLine("Número do cartão: " + Convert.ToString(NumCartao));
            SwTransacao.WriteLine("Número do CVV: " + CVV);
            SwTransacao.WriteLine("Data de validade do Cartão: " + Validade);

            SwTransacao.Close();
        }

        public static void EscreverCartaoCadastrado(int NumCartao, string CVV, string Validade, string Dono, string Nome)
        {
            // Transacao

            StreamWriter SwTransacao = new StreamWriter(@"C:\SharkBank\Usuario\User_" + Dono + @"\" + @"Cartao\" + "Cartao_Cadastrado_" + Dono + ".txt");
            SwTransacao.WriteLine("Nome: " + Nome);
            SwTransacao.WriteLine("Número do cartão: " + Convert.ToString(NumCartao));
            SwTransacao.WriteLine("Número do CVV: " + CVV);
            SwTransacao.WriteLine("Data de validade do Cartão: " + Validade);

            SwTransacao.Close();
        }



    }
}
