using MaromFit.ServiceReferenceCorreios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaromFit.Controllers
{
    public class SalesController : Controller
    {
        // GET: Sales
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult CorreiosCalc(string cep)
        {
            //Dados da empresa, se tiver contrato com os Correios
            string nCdEmpresa = string.Empty;
            string sDsSenha = string.Empty;
            // Código do tipo de frete
            //41106 - PAC
            //40010 - SEDEX
            //40045 - SEDEX a Cobrar
            //40215 - SEDEX 10
            //40290 - SEDEX Hoje
            string nCdServico = "41106";
            // Cep de origem e destino - apenas números
            string sCepOrigem = "19940000";
            string sCepDestino = "06192220";
            // Peso total da encomenda - por padrão deixei 1kg
            string nVlPeso = Convert.ToString(1);
            // Formato da encomenda - por padrão deixei caixa
            int nCdFormato = 1;
            // Para encomenda do tipo PAC, deve-se preencher a dimensão da embalagem
            decimal nVlComprimento = 20;
            decimal nVlAltura = 20;
            decimal nVlLargura = 20;
            decimal nVlDiametro = 0;
            // Informa se é por mão própria - por padrão deixei Não
            string sCdMaoPropria = "N";
            // Valor declarado - por padrão não informo
            decimal nVlValorDeclarado = 0;
            // Se desejo recebr aviso de recebimento - por padrão não quero
            string sCdAvisoRecebimento = "N";


            CalcPrecoPrazoWSSoapClient wsCorreios2 = new CalcPrecoPrazoWSSoapClient();

            cResultado retornoCorreios = wsCorreios2.CalcPrecoPrazo(nCdEmpresa, sDsSenha, nCdServico,
                sCepOrigem, sCepDestino, nVlPeso, nCdFormato, nVlComprimento, nVlAltura, nVlLargura, nVlDiametro,
                sCdMaoPropria, nVlValorDeclarado, sCdAvisoRecebimento);

            string[] result = new string[2];
            result[1] = retornoCorreios.Servicos[0].PrazoEntrega;
            result[0] = retornoCorreios.Servicos[0].Valor;

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}