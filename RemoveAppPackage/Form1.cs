using System.Diagnostics;

namespace RemoveAppPackage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            string command = "Get-AppxPackage | format-wide";
            string result = RunPowerShellCommand(command);

            // Exibe o resultado na TextBox1
            txtlista.Text = result;
        }

        private void btnapagar_Click(object sender, EventArgs e)
        {
            string packageName = txtpackage.Text.Trim();

            if (string.IsNullOrEmpty(packageName))
            {
                MessageBox.Show("Por favor, insira o nome do pacote na TextBox2.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Executa o comando PowerShell Remove-AppxPackage
            string command = $"Get-AppxPackage {packageName} -AllUsers | Remove-AppxPackage";
            string result = RunPowerShellCommand(command);

            // Exibe o resultado na TextBox1
            txtlista.Text = result;
        }

        private string RunPowerShellCommand(string command)
        {
            // Configura o processo do PowerShell
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy unrestricted -Command {command}",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            // Executa o processo
            using (Process process = new Process())
            {
                process.StartInfo = processStartInfo;
                process.Start();

                // Captura a saída e os erros
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                process.WaitForExit();

                // Retorna a saída ou o erro
                if (!string.IsNullOrEmpty(error))
                {
                    return $"Erro: {error}";
                }
                return output;
            }
        }

    }
}
