using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Matrices;

namespace Practica_006
{
    public partial class Form1 : Form
    {
        //Indices para los arreglos
        int i = 0,j=0;
        //Variables para saber que opción está activa en los combobox
        string opc,op;

        //Arreglos con los que se hacen las operaciones
        float[,,,,] matrizA = new float[5,5,5,5,5];
        float[,,,,] matrizB = new float[5,5,5,5,5];
        //En este arreglo se guardan los resultados
        float[,,,,] matrizC = new float[5,5,5,5,5];
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        //Boton para utilizar la calculadora de matrices
        private void TopicosBtt_Click(object sender, EventArgs e)
        {
            MetodosGrpBox.Visible = false;
            MatrcicesOpGrpBox.Visible = true;
            
            

        }
        //Boton para utilizar el solucionador de sistemas de ecuaciones
        private void MetodosBtt_Click(object sender, EventArgs e)
        {
            MatrcicesOpGrpBox.Visible = false;
            MetodosGrpBox.Visible = true;
            
        }

        private void MetodosGrpBox_Enter(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
        //Método donde se comprueba el tamaño de la matriz
        public void TamañoStatus()
        {
            //El texto del combobox del tamaño se guarda en la variable opc
            opc = TamañoCmBx.Text;
            

        }
        //Este método toma los datos de la matriz 'A' (que se toman de los textbox dentro del groupbox MatrizAGrpBox), y los guarda en un arreglo
        public void GetDataA()
        {
            switch (opc)
            {
                case "2x2":
                    i = 0;
                    j = 0;
                    foreach (Control e in MatrizAGrpBox.Controls)
                    {
                        if (e.TabIndex < 2)
                        {
                            matrizA[i, 0, 0, 0, 0] = int.Parse(e.Text);
                            i++;
                        }
                        else if (e.TabIndex > 4 && e.TabIndex < 7)
                        {
                            j++;
                            if (i == 5)
                            {
                                i = 0;
                            }
                            else if (i == 2)
                            {
                                i = 0;
                            }
                            if (j > 1)
                            {
                                j = 1;
                            }
                            matrizA[i, j, 0, 0, 0] = int.Parse(e.Text);
                            i++;

                        }
                        


                    }

                    break;

                case "3x3":
                    i = 0;
                    j = 0;
                   // k = 0;
                    foreach (Control e in MatrizAGrpBox.Controls)
                    {
                        if (e.TabIndex < 3)
                        {
                            matrizA[i, 0, 0, 0, 0] = int.Parse(e.Text);
                            i++;
                        }
                        else if (e.TabIndex > 4 && e.TabIndex < 8)
                        {
                            j++;
                            if (i == 5)
                            {
                                i = 0;
                            }
                            else if (i == 3)
                            {
                                i = 0;
                            }
                            if (j > 1)
                            {
                                j = 1;
                            }
                            matrizA[i, j, 0, 0, 0] = int.Parse(e.Text);
                            i++;

                        }
                        else if(e.TabIndex >9 && e.TabIndex < 13)
                        {
                            j++;
                            if (i == 5)
                            {
                                i = 0;
                            }
                            else if (i == 3)
                            {
                                i = 0;
                            }
                            if (j > 2)
                            {
                                j = 2;
                            }
                            matrizA[i, j, 0, 0, 0] = int.Parse(e.Text);
                            i++;
                        }



                    }

                    break;

            }

        }
        //Este método toma los datos del arreglo 'MatrizC' (que ha obtenido los datos desde el método de la operación correspondiente declarado en la libreria creada), y los guarda en la Matriz Resultado, que son los textbos dentro del groupbox MatrizCGrpBox

        public void SetDataC()
        {
            switch (opc)
            {
                case "2x2":
                    i = 0;
                    j = 0;
                    foreach (Control e in MatrizCGrpBox.Controls)
                    {
                        if (e.TabIndex < 2)
                        {
                            e.Text = matrizC[i, 0, 0, 0, 0].ToString();
                            i++;
                        }
                        else if (e.TabIndex > 4 && e.TabIndex < 7)
                        {
                            j++;
                            if (i == 5)
                            {
                                i = 0;
                            }
                            else if(i== 2)
                            {
                                i = 0;
                            }
                            if(j > 1)
                            {
                                j = 1;
                            }
                            e.Text = matrizC[i, j, 0, 0, 0].ToString();
                            i++;

                        }
                        


                    }
                    

                    break;

                case "3x3":
                    i = 0;
                    j = 0;
                    //k = 0;
                    foreach (Control e in MatrizCGrpBox.Controls)
                    {
                        if (e.TabIndex < 3)
                        {
                            e.Text = matrizC[i, j, 0, 0, 0].ToString();
                            i++;
                        }
                        else if (e.TabIndex > 4 && e.TabIndex < 8)
                        {
                            j++;
                            if (i == 5)
                            {
                                i = 0;
                            }
                            else if (i == 3)
                            {
                                i = 0;
                            }
                            if (j > 1)
                            {
                                j = 1;
                            }
                            e.Text = matrizC[i, j, 0, 0, 0].ToString();
                            i++;

                        }
                        else if (e.TabIndex > 9 && e.TabIndex < 13)
                        {
                            j++;
                            if (i == 5)
                            {
                                i = 0;
                            }
                            else if (i == 3)
                            {
                                i = 0;
                            }
                            if (j > 2)
                            {
                                j = 2;
                            }
                            e.Text = matrizC[i, j, 0, 0, 0].ToString();
                            i++;
                        }



                    }

                    break;

            }

        }
        //Botón que ejecuta los métodos necesarios para realizar la operación
        private void CalcularBtt_Click(object sender, EventArgs e)
        {
            TamañoStatus();
            GetDataA();
            GetDataB();
            OpStatus();
            Operacion();
            SetDataC();



        }
        //Este método comprueba la operacion a realizarse
        public void OpStatus()
        {
            //Se toma el texto en 
            op = OperacionCmBx.Text;
        }


        //En este método se realiza la operación correspondiente a la selección en el combobox de la operación,
        // y en el combobox del tamaño, llamando el método correspondiente desde la librería creada por nosotros
        public void Operacion()
        {
            switch (op)
            {
                case "A+B":
                    if (opc == "2x2")
                    {
                        matrizC = Suma.DosxDos(matrizA, matrizB);

                    }
                    else if (opc == "3x3")
                    {
                        matrizC = Suma.TresxTres(matrizA, matrizB);

                    }
                    else if (opc == "4x4")
                    {
                        matrizC = Suma.CuatroxCuatro(matrizA, matrizB);

                    }
                    else if (opc == "5x5")
                    {
                        matrizC = Suma.CincoxCinco(matrizA, matrizB);
                    }

                    break;

                case "B-A":
                    if (opc == "2x2")
                    {
                        matrizC = Resta.DosxDos(matrizB, matrizA);

                    }
                    else if (opc == "3x3")
                    {
                        matrizC = Resta.TresxTres(matrizB, matrizA);

                    }
                    else if (opc == "4x4")
                    {
                        matrizC = Resta.CuatroxCuatro(matrizB, matrizA);

                    }
                    else if (opc == "5x5")
                    {
                        matrizC = Resta.CincoxCinco(matrizB, matrizA);
                    }

                    break;

                case "A-B":
                    if (opc == "2x2")
                    {
                        matrizC = Resta.DosxDos(matrizA, matrizB);

                    }
                    else if (opc == "3x3")
                    {
                        matrizC = Resta.TresxTres(matrizA, matrizB);

                    }
                    else if (opc == "4x4")
                    {
                        matrizC = Resta.CuatroxCuatro(matrizA, matrizB);

                    }
                    else if (opc == "5x5")
                    {
                        matrizC = Resta.CincoxCinco(matrizA, matrizB);
                    }

                    break;

                case "B*A":
                    if (opc == "2x2")
                    {
                        matrizC = Multiplicacion.DosxDos(matrizA, matrizB);

                    }
                    else if (opc == "3x3")
                    {
                        matrizC = Multiplicacion.TresxTres(matrizA, matrizB);

                    }
                    else if (opc == "4x4")
                    {
                        matrizC = Multiplicacion.CuatroxCuatro(matrizA, matrizB);

                    }
                    else if (opc == "5x5")
                    {
                        matrizC = Multiplicacion.CincoxCinco(matrizA, matrizB);
                    }

                    break;

                case "Suma de la diagonal":
                    if (opc == "2x2")
                    {
                        matrizC = Diagonal.DosxDos(matrizA, matrizB);

                    }
                    else if (opc == "3x3")
                    {
                        matrizC = Diagonal.TresxTres(matrizA, matrizB);

                    }
                    else if (opc == "4x4")
                    {
                        matrizC = Diagonal.CuatroxCuatro(matrizA, matrizB);

                    }
                    else if (opc == "5x5")
                    {
                        matrizC = Diagonal.CincoxCinco(matrizA, matrizB);
                    }

                    break;
            }
        }

       
         //El método TamañoStatus() para tomar el tamaño de la matriz desde el combobox del tamaño.
        //Y el método UiStatus() para mostrar las matrices correspondientes al tamaño seleccionado en el combobox de tamaño
        private void TamañoCmBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            TamañoStatus();
            UiStatus();
        }
        //Este método toma los datos de la matriz 'B' (que se toman de los textbox dentro del groupbox MatrizBGrpBox), y los guarda en un arreglo

        public void GetDataB()
        {
            switch (opc)
            {
                case "2x2":


                    i = 0;
                    j = 0;
                    foreach (Control e in MatrizBGrpBox.Controls)
                    {
                        if (e.TabIndex < 2)
                        {
                            matrizB[i, 0, 0, 0, 0] = int.Parse(e.Text);
                            i++;
                        }
                        else if (e.TabIndex > 4 && e.TabIndex < 7)
                        {
                            j++;
                            if (i == 5)
                            {
                                i = 0;
                            }
                            else if (i == 2)
                            {
                                i = 0;
                            }
                            if (j > 1)
                            {
                                j = 1;
                            }
                            matrizB[i, j, 0, 0, 0] = int.Parse(e.Text);
                            i++;
                            
                        }
                       


                    }

                    break;

                case "3x3":
                    i = 0;
                    j = 0;
                    //k = 0;
                    foreach (Control e in MatrizBGrpBox.Controls)
                    {
                        if (e.TabIndex < 3)
                        {
                            matrizB[i, 0, 0, 0, 0] = int.Parse(e.Text);
                            i++;
                        }
                        else if (e.TabIndex > 4 && e.TabIndex < 8)
                        {
                            j++;
                            if (i == 5)
                            {
                                i = 0;
                            }
                            else if (i == 3)
                            {
                                i = 0;
                            }
                            if (j > 1)
                            {
                                j = 1;
                            }
                            matrizB[i, j, 0, 0, 0] = int.Parse(e.Text);
                            i++;

                        }




                    }

                    break;

            }

        }

       
        
        
        //Este método hace visibles los texbox dentro de los tres groupbox que representan a las matrices, dependiendo del tamañao seleccionado en el combobox del tamaño
        //Para eso se utilizaron los indices de los texbox para que dependiendo el tamaño de la matriz, solo se mostraran los textbox +
        //correspondientes, y dar la sensación de que se está viendo la matriz del tamaño seleccionado
        public void UiStatus()
        {
            switch (opc)
            {
                case "2x2":



                    foreach (Control e in MatrizAGrpBox.Controls)
                    {
                        if (e.TabIndex < 2)
                        {
                            e.Visible = true;
                        }
                        else if (e.TabIndex > 4 && e.TabIndex < 7)
                        {
                            e.Visible = true;
                        }
                        else
                        {
                            e.Visible = false;
                        }


                    }

                    foreach (Control e in MatrizBGrpBox.Controls)
                    {
                        if (e.TabIndex < 2)
                        {
                            e.Visible = true;
                        }
                        else if (e.TabIndex > 4 && e.TabIndex < 7)
                        {
                            e.Visible = true;
                        }
                        else
                        {
                            e.Visible = false;
                        }


                    }

                    foreach (Control e in MatrizCGrpBox.Controls)
                    {
                        if (e.TabIndex < 2)
                        {
                            e.Visible = true;
                        }
                        else if (e.TabIndex > 4 && e.TabIndex < 7)
                        {
                            e.Visible = true;
                        }
                        else
                        {
                            e.Visible = false;
                        }


                    }

                    break;

                case "3x3":

                    foreach (Control e in MatrizAGrpBox.Controls)
                    {
                        if (e.TabIndex < 3)
                        {
                            e.Visible = true;
                        }
                        else if (e.TabIndex > 4 && e.TabIndex < 8)
                        {
                            e.Visible = true;
                        }
                        else if (e.TabIndex > 9 && e.TabIndex < 13)
                        {
                            e.Visible = true;
                        }
                        else
                        {
                            e.Visible = false;
                        }
                    }

                    foreach (Control e in MatrizBGrpBox.Controls)
                    {
                        if (e.TabIndex < 3)
                        {
                            e.Visible = true;
                        }
                        else if (e.TabIndex > 4 && e.TabIndex < 8)
                        {
                            e.Visible = true;
                        }
                        else if (e.TabIndex > 9 && e.TabIndex < 13)
                        {
                            e.Visible = true;
                        }
                        else
                        {
                            e.Visible = false;
                        }
                    }

                    foreach (Control e in MatrizCGrpBox.Controls)
                    {
                        if (e.TabIndex < 3)
                        {
                            e.Visible = true;
                        }
                        else if (e.TabIndex > 4 && e.TabIndex < 8)
                        {
                            e.Visible = true;
                        }
                        else if (e.TabIndex > 9 && e.TabIndex < 13)
                        {
                            e.Visible = true;
                        }
                        else
                        {
                            e.Visible = false;
                        }
                    }


                    break;

                case "4x4":

                    foreach (Control e in MatrizAGrpBox.Controls)
                    {
                        if (e.TabIndex < 4)
                        {
                            e.Visible = true;
                        }
                        else if (e.TabIndex > 4 && e.TabIndex < 9)
                        {
                            e.Visible = true;
                        }
                        else if (e.TabIndex > 9 && e.TabIndex < 14)
                        {
                            e.Visible = true;
                        }
                        else if (e.TabIndex > 14 && e.TabIndex < 19)
                        {
                            e.Visible = true;
                        }
                        else
                        {
                            e.Visible = false;
                        }
                    }

                    foreach (Control e in MatrizBGrpBox.Controls)
                    {
                        if (e.TabIndex < 4)
                        {
                            e.Visible = true;
                        }
                        else if (e.TabIndex > 4 && e.TabIndex < 9)
                        {
                            e.Visible = true;
                        }
                        else if (e.TabIndex > 9 && e.TabIndex < 14)
                        {
                            e.Visible = true;
                        }
                        else if (e.TabIndex > 14 && e.TabIndex < 19)
                        {
                            e.Visible = true;
                        }
                        else
                        {
                            e.Visible = false;
                        }
                    }

                    foreach (Control e in MatrizCGrpBox.Controls)
                    {
                        if (e.TabIndex < 4)
                        {
                            e.Visible = true;
                        }
                        else if (e.TabIndex > 4 && e.TabIndex < 9)
                        {
                            e.Visible = true;
                        }
                        else if (e.TabIndex > 9 && e.TabIndex < 14)
                        {
                            e.Visible = true;
                        }
                        else if (e.TabIndex > 14 && e.TabIndex < 19)
                        {
                            e.Visible = true;
                        }
                        else
                        {
                            e.Visible = false;
                        }
                    }

                    break;

                case "5x5":

                    
                    
                    foreach (Control e in MatrizAGrpBox.Controls)
                    {

                        e.Visible = true;
                    }

                    
                    foreach (Control e in MatrizBGrpBox.Controls)
                    {

                        e.Visible = true;
                    }

                    
                    foreach (Control e in MatrizCGrpBox.Controls)
                    {

                        e.Visible = true;
                    }




                    break;
            }
        }


    }
}
