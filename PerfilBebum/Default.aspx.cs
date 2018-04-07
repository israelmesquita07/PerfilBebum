using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    WebService.WebServiceSoapClient cliente = new WebService.WebServiceSoapClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ddlBebidas.DataSource = cliente.Bebidas();
            ddlBebidas.DataValueField = "Id";
            ddlBebidas.DataTextField = "Descricao";
            ddlBebidas.DataBind();
            ddlBebidas.Items.Insert(0, new ListItem("Selecione", "0")); //Além das Bebidas, insere-se uma opção "Selecione" para ficar mais intuitivo.
        }
    }

    protected void ddlBebidas_SelectedIndexChanged(object sender, EventArgs e)
    {
        var valorSelecionado = ddlBebidas.SelectedValue;
        if (!String.IsNullOrEmpty(valorSelecionado) && valorSelecionado != "0") //Verifica se o valor selecionado é válido.
        {
            ddlDoses.DataSource = cliente.Doses(int.Parse(valorSelecionado));
            ddlDoses.DataValueField = "Id";
            ddlDoses.DataTextField = "QuantidadeDose";
            ddlDoses.DataBind();
        }
        else
        {
            ddlDoses.DataSource = "";
            ddlDoses.DataBind();
        }

    }

    protected void btnGerarPerfil_Click(object sender, EventArgs e)
    {
        var id_Doses = ddlDoses.SelectedValue;
        if (!String.IsNullOrEmpty(id_Doses))
        {
            List<string> perfil = cliente.Perfil(int.Parse(id_Doses)).ToList(); //Retorna o perfil segundo o que foi informado no formulário.
            Response.Write("<script>alert('O seu Perfil é de um " + perfil[0] + " " + perfil[1] + "');</script>");
        }
        else
        {
            Response.Write("<script>alert('Selecione opções válidas');</script>"); //Caso o valor selecionado seja inválido, retorna esta mensagem para o usuário.
        }
    }
}