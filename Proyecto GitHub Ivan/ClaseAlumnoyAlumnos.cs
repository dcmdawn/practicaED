using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox aluNota;
        private TextBox listaAlumnos;
        private TextBox aluNombre;
        private Button button1;
        Alumnos misAlumnos = new Alumnos();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.aluNota = new System.Windows.Forms.TextBox();
            this.listaAlumnos = new System.Windows.Forms.TextBox();
            this.aluNombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Listado de alumnos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nota";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre Alumno:";
            // 
            // aluNota
            // 
            this.aluNota.Location = new System.Drawing.Point(272, 38);
            this.aluNota.Name = "aluNota";
            this.aluNota.Size = new System.Drawing.Size(100, 20);
            this.aluNota.TabIndex = 10;
            // 
            // listaAlumnos
            // 
            this.listaAlumnos.Location = new System.Drawing.Point(88, 95);
            this.listaAlumnos.Multiline = true;
            this.listaAlumnos.Name = "listaAlumnos";
            this.listaAlumnos.ReadOnly = true;
            this.listaAlumnos.Size = new System.Drawing.Size(469, 247);
            this.listaAlumnos.TabIndex = 9;
            // 
            // aluNombre
            // 
            this.aluNombre.Location = new System.Drawing.Point(88, 38);
            this.aluNombre.Name = "aluNombre";
            this.aluNombre.Size = new System.Drawing.Size(178, 20);
            this.aluNombre.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(425, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Actualizar alumno";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(644, 365);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aluNota);
            this.Controls.Add(this.listaAlumnos);
            this.Controls.Add(this.aluNombre);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Alumno miAlumno = new Alumno();
            String miAlumnoStr, miAlumnoNotaTexto;
            miAlumno.Nombre = aluNombre.Text;
            miAlumno.Nota = Convert.ToInt32(aluNota.Text);
            if (miAlumno.Nota < 5)
            {
                miAlumnoNotaTexto = "Suspenso";
            }
            else if (miAlumno.Nota < 7)
            {
                miAlumnoNotaTexto = "Aprobado";
            }

            else if (miAlumno.Nota < 9)
            {
                miAlumnoNotaTexto = "Notable";
            }
            else
                miAlumnoNotaTexto = "Sobresaliente";
            miAlumnoStr = aluNombre.Text + " " + aluNota.Text + " " +
            miAlumnoNotaTexto + "\n";
            listaAlumnos.AppendText(miAlumnoStr);
            misAlumnos.Agregar(miAlumno);

        }




        class Alumno
        {
            private string nombre;
            private int nota;
            public string Nombre
            {
                get { return nombre; }
                set { nombre = value; }
            }
            public int Nota
            {
                get { return nota; }
                set
                {
                    if (value >= 0 && value <= 10)
                        nota = value;
                }
            }
            public Boolean Aprobado
            {
                get
                {
                    if (nota >= 5)
                        return true;
                    else
                        return false;
                }
            }
        }

        class Alumnos
        {
            private ArrayList listaAlumnos = new ArrayList();

            // Agrega un nuevo alumno a la lista
            //        
            public void Agregar(Alumno alu)
            {
                listaAlumnos.Add(alu);
            }

            // Devuelve el alumno que está en la posición num
            //
            public Alumno Obtener(int num)
            {
                if (num >= 0 && num <= listaAlumnos.Count)
                {
                    return ((Alumno)listaAlumnos[num]);
                }
                return null;
            }

            // Devuelve la nota media de los alumnos
            //
            public float Media
            {
                get
                {
                    if (listaAlumnos.Count == 0)
                        return 0;
                    else
                    {
                        float media = 0;
                        for (int i = 0; i < listaAlumnos.Count; i++)
                        {
                            media += ((Alumno)listaAlumnos[i]).Nota;
                        }
                        return (media / listaAlumnos.Count);
                    }
                }
            }
        }


    }
}
    

