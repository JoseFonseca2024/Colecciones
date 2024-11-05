using System.Collections;

namespace PracticaColecciones
{
    public partial class Form1 : Form
    {

        //Definición de colecciones no genericas
        private ArrayList miArrayList;
        private Hashtable miHastable;
        private Queue miQueue;
        public Form1()
        {
            InitializeComponent();

            //Inicialización de colecciones
            miArrayList = new ArrayList();
            miHastable = new Hashtable();
            miQueue = new Queue();

        }

        private void AgregaraArrayList(object sender, EventArgs e)
        {
            string elemento = txtElemento.Text.Trim();
            if (!string.IsNullOrEmpty(elemento))
            {
                miArrayList.Add(elemento);
                ActualizarListBox();
                txtElemento.Clear();
            }
            else
            {
                MessageBox.Show("Por favor ingrese un valor valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Agregarhastable(object sender, EventArgs e)
        {
            //Agregar un par clave-valor
            string clave = txtElemento.Text.Trim();
            string valor = txtValor.Text.Trim();

            if (!string.IsNullOrEmpty(clave) && !string.IsNullOrEmpty(valor))
            {
                if (!miHastable.ContainsKey(clave))
                {
                    miHastable.Add(clave, valor);
                    ActualizarListBox();
                    txtElemento.Clear();
                    txtValor.Clear();
                }
                else
                {
                    MessageBox.Show("La clave no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un valor valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AgregarQueue(object sender, EventArgs e)
        {
            string elemento = txtElemento.Text.Trim();
            if (!string.IsNullOrEmpty(elemento))
            {
                miQueue.Enqueue(elemento);
                ActualizarListBox();
                txtElemento.Clear();
            }
            else
            {
                MessageBox.Show("Por favor ingrese un valor valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProcesarQueue(object sender, EventArgs e)
        {
            if (miQueue.Count > 0)
            {
                string procesado = (string)miQueue.Dequeue();
                MessageBox.Show($"Elemento procesado: {procesado}", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay elementos en la cola", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarListBox()
        {
            //Actualizar el ListBox con los elementos de las colecciones

            lstColecciones.Items.Clear();

            //Mostrar contenidos del ArrayList
            lstColecciones.Items.Add("ArrayList: ");
            foreach (var item in miArrayList)
            {
                lstColecciones.Items.Add(item.ToString());
            }

            //Mostrar contendio del Hashtable
            lstColecciones.Items.Add("\nHashtable (Clave-Valor):");
            foreach (DictionaryEntry entry in miHastable)
            {
                lstColecciones.Items.Add($"Clave: {entry.Key}, Valor {entry.Value}");
            }

            //Mostrar contenido del Queue
            lstColecciones.Items.Add("\nQueue:");
            foreach (var item in miQueue)
            {
                lstColecciones.Items.Add(item.ToString());
            }

        }

    }
}
