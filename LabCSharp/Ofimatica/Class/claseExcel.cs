using System;
using System.Collections.Generic;
using Microsoft.Office.Interop.Excel;

namespace LabCSharp.Ofimatica.Class
{
    class claseExcel
    {

#pragma warning disable CS0246 // El nombre del tipo o del espacio de nombres 'Workbook' no se encontró (¿falta una directiva using o una referencia de ensamblado?)
        public Workbook workbook;
#pragma warning restore CS0246 // El nombre del tipo o del espacio de nombres 'Workbook' no se encontró (¿falta una directiva using o una referencia de ensamblado?)
#pragma warning disable CS0246 // El nombre del tipo o del espacio de nombres 'Worksheet' no se encontró (¿falta una directiva using o una referencia de ensamblado?)
        public Worksheet worksheet;
#pragma warning restore CS0246 // El nombre del tipo o del espacio de nombres 'Worksheet' no se encontró (¿falta una directiva using o una referencia de ensamblado?)
#pragma warning disable CS0246 // El nombre del tipo o del espacio de nombres 'Range' no se encontró (¿falta una directiva using o una referencia de ensamblado?)
        public Range range;
#pragma warning restore CS0246 // El nombre del tipo o del espacio de nombres 'Range' no se encontró (¿falta una directiva using o una referencia de ensamblado?)
        public string dirArchivo;

        public claseExcel() {

        }

        public claseExcel(string dirArchivo)
        {

        }

        public void combinarArchivos(List<string> listadoArchivos)
        {
            
        }

        public void combinarHojas(string dirArchivo)
        {
            //declaracion de variables de Excel
            Application miExcel = new Application();
            Workbook miWorkbook = miExcel.Workbooks.Open(dirArchivo);

            //contar cantidad de hojas
            Worksheet miWorksheetDestino = miWorkbook.Sheets[1];
            int cantWS = miWorkbook.Sheets.Count;
            Console.WriteLine("ES " + cantWS);

            for (int i = 2; i <= cantWS; i++)
            {
                miWorksheetDestino.Copy(miWorkbook.Sheets[i]);
            }

            miWorkbook.Save();
            miWorkbook.Close();
            miExcel.Quit();
        }

        public void generarListado(string dirArchivo)
        {
            //declaracion de arreglos
            string[,] tracking;
            tracking = new string[4000,3];

            //declaracion de variables de Excel
            Application miExcel = new Application();
            miExcel.Visible = false;
            Workbook workbook = miExcel.Workbooks.Open(dirArchivo);
            Worksheet worksheet = workbook.Sheets[1];
            Worksheet worksheet_PM = workbook.Sheets[2];
            Worksheet worksheet_OC = workbook.Sheets[3];
            Worksheet worksheet_REC = workbook.Sheets[4];
            Worksheet worksheet_TRACK = workbook.Sheets[5];

            int pm, oc, rec, track, totalPM, totalOC, totalREC, totalTRACK, fila;
            int contOC, contREC;
            string nroPM, nroOC, nroREC, origenPM, origenOC, origenREC, tipoTRACK;

            totalPM = worksheet_PM.UsedRange.Rows.Count;
            totalOC = worksheet_OC.UsedRange.Rows.Count;
            totalREC = worksheet_REC.UsedRange.Rows.Count;
            totalTRACK = worksheet_TRACK.UsedRange.Rows.Count;

            System.Console.Out.WriteLine(totalPM);
            System.Console.Out.WriteLine(totalOC);
            System.Console.Out.WriteLine(totalREC);

            fila = 0;
            tracking[0, 0] = "NRO_PM";
            tracking[0, 1] = "NRO_OC";
            tracking[0, 2] = "NRO_REC";
            fila = 1;

            for (pm = 2; pm < totalPM; pm++)
            {
                nroPM = (string)worksheet_PM.Cells[pm, 2].Value2;
                contOC = 0;

                for (track = 2; track < totalTRACK; track++)
                {
                    nroOC = (string)worksheet_TRACK.Cells[track, 2].Value2;
                    tipoTRACK = (string)worksheet_TRACK.Cells[track, 3].Value2;
                    origenPM = (string)worksheet_TRACK.Cells[track, 8].Value2;

                    if (string.Equals(nroPM, origenPM) && string.Equals(tipoTRACK,"Orden de Compra"))
                    {

                        tracking[fila, 0] = nroPM;
                        tracking[fila, 1] = nroOC;
                        System.Console.Out.WriteLine("nroPM: " + tracking[fila,0] + " " + "nroOC: " + tracking[fila,1]);
                        fila++;
                    }

                    contOC++;
                    if (contOC > 31)
                    {
                        break;
                    }
                }
            }

            workbook.Save();
            workbook.Close();
            miExcel.Quit();
        }

        public void generarSC()
        {

        }
    }
}
