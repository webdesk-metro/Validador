using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Animation;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace Validador
{
    public partial class Validy : MetroForm
    {
        public Validy()
        {
            InitializeComponent();
        }

        private void Validy_Load(object sender, EventArgs e)
        {

        }

        private void tbx_doc_Enter(object sender, EventArgs e)
        {
            MoveAnimation move = new MoveAnimation();
            move.Start(MessageBar, new Point(0, -40), TransitionType.EaseInCubic, 20);
        }

        private void tbx_doc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 46 && e.KeyChar != 45)
            {
                MoveAnimation move = new MoveAnimation();

                e.Handled = true;

                MessageBar.Style = MetroColorStyle.Red;
                MessageBar.Text = "Opps! Este campo só aceita números...";

                move.Start(MessageBar, new Point(0, 0), TransitionType.EaseInCubic, 20);
            }
        }

        private void lnk_go_Click(object sender, EventArgs e)
        {
            MoveAnimation move = new MoveAnimation();

            move.Start(MessageBar, new Point(0, 0), TransitionType.EaseInCubic, 20);

            if(tbx_doc.Text.Length != 0)
            {
                if (rbt_cnpj.Checked)
                {
                    if (ValidarCNPJ(tbx_doc.Text))
                    {
                        MessageBar.Style = MetroColorStyle.Green;
                        MessageBar.Text = ValidarCPF(tbx_doc.Text).ToString();
                    }
                    else
                    {
                        MessageBar.Style = MetroColorStyle.Red;
                        MessageBar.Text = ValidarCPF(tbx_doc.Text).ToString();
                    }
                }
                else if (rbt_cpf.Checked)
                {
                    if (ValidarCPF(tbx_doc.Text))
                    {
                        MessageBar.Style = MetroColorStyle.Green;
                        MessageBar.Text = ValidarCPF(tbx_doc.Text).ToString();
                    }
                    else
                    {
                        MessageBar.Style = MetroColorStyle.Red;
                        MessageBar.Text = ValidarCPF(tbx_doc.Text).ToString();
                    }
                }
                else if (rbt_pis.Checked)
                {
                    if (ValidarPIS(tbx_doc.Text))
                    {
                        MessageBar.Style = MetroColorStyle.Green;
                        MessageBar.Text = ValidarCPF(tbx_doc.Text).ToString();
                    }
                    else
                    {
                        MessageBar.Style = MetroColorStyle.Red;
                        MessageBar.Text = ValidarCPF(tbx_doc.Text).ToString();
                    }
                }
            }
            else
            {
                MessageBar.Style = MetroColorStyle.Red;
                MessageBar.Text = "Opps! Nada foi digitado...";
            }
        }

        private void MessageBar_Click(object sender, EventArgs e)
        {
            MoveAnimation move = new MoveAnimation();
            move.Start(MessageBar, new Point(0, -40), TransitionType.EaseInCubic, 20);
        }

        private static bool ValidarCPF(string cpf)
        {
            int soma = 0, resto;
            string temp, digito;

            int[] mt1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] mt2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
                return false;

            temp = cpf.Substring(0, 9);

            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(temp[i].ToString()) * mt1[i];
            }

            resto = soma % 11;

            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }

            digito = resto.ToString();
            temp = temp + digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(temp[i].ToString()) * mt2[i];
            }

            resto = soma % 11;

            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }

        private static bool ValidarCNPJ(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;

            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

            if (cnpj.Length != 14)
                return false;

            tempCnpj = cnpj.Substring(0, 12);

            soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            resto = (soma % 11);

            if(resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;

            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);

            if(resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cnpj.EndsWith(digito);
        }

        private static bool ValidarPIS(string pis)
        {
            int[] multiplicador = new int[10] { 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;

            if (pis.Trim().Length != 11)
                return false;

            pis = pis.Trim();
            pis = pis.Replace("-", "").Replace(".", "").PadLeft(11, '0');

            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(pis[i].ToString()) * multiplicador[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            return pis.EndsWith(resto.ToString());
        }
    }
}
