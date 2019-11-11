using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;



using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Windows.Forms;
using logica;


using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;



namespace logica

{
    public class ExportarDesp
    {
        int columnas;
        public void ExportarDataGridViewExcel(DataGridView dgView, DataGridView dgView2, string Fechad, string Fechah, string IngEgr, string Stf, string dif,string porcent)
        {
        
            
            string sFont = "Verdana";
            int iSize = 10;
            //CREACIÓN DE LOS OBJETOS DE EXCEL
            Excel.Application xlsApp = new Excel.Application();
            Excel.Worksheet xlsSheet;
            Excel.Workbook xlsBook;
            //AGREGAMOS EL LIBRO Y HOJA DE EXCEL
            xlsBook = xlsApp.Workbooks.Add(true);
            xlsSheet = (Excel.Worksheet)xlsBook.ActiveSheet;
            //ESPECIFICAMOS EL TIPO DE LETRA Y TAMAÑO DE LA LETRA DEL LIBRO
            xlsSheet.Rows.Cells.Font.Size = iSize;
            xlsSheet.Rows.Cells.Font.Name = sFont;
            xlsSheet.Cells.Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            //AGREGAMOS LOS ENCABEZADOS
            int iFil = 0, iCol = 0;
            foreach (DataGridViewColumn column in dgView.Columns)
                if (column.Visible)
                    xlsSheet.Cells[2, ++iCol] = column.HeaderText;

            xlsSheet.Cells[1, 1] = dif +" "+ Fechad +" - "+Fechah;
            //MARCAMOS LAS CELDAS DEL ENCABEZADO EN NEGRITA Y EN COLOR DE RELLENO GRIS
            xlsSheet.Range[xlsSheet.Cells[2, 1], xlsSheet.Cells[2, dgView.ColumnCount]].Font.Bold = true;
            xlsSheet.Range[xlsSheet.Cells[2, 1], xlsSheet.Cells[2, dgView.ColumnCount]].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightSkyBlue);

            
            


            //RECORRIDO DE LAS FILAS Y COLUMNAS (PINTADO DE CELDAS) 
            Excel.Range r;
            Color c;
            for (iFil = 0; iFil < dgView.RowCount; iFil++)
            {
                for (iCol = 0; iCol < dgView.ColumnCount; iCol++)
                {

                    if (iCol == 1 && dgView.Rows[iFil].Cells[iCol].Value.ToString()!="")
                    {
                        DateTime fecha = Convert.ToDateTime(dgView.Rows[iFil].Cells[iCol].Value.ToString());
                        xlsSheet.Cells[iFil + 3, iCol + 1] = Convert.ToString(fecha.ToString("dd/MMMM/yyyy"));
                        //xlsSheet.Cells[iFil + 3, iCol + 1] = dgView.Rows[iFil].Cells[iCol].Value.ToString();
                    }
                    else { 
                        xlsSheet.Cells[iFil + 3, iCol + 1] = dgView.Rows[iFil].Cells[iCol].Value.ToString();
                    }
                    if(iFil== dgView.RowCount - 1)
                    {
                        if (iCol == 6)
                        {
                            xlsSheet.Cells[1, 7]= dgView.Rows[iFil].Cells[iCol].Value.ToString();
                        }
                        if (iCol == 7)
                        {
                            xlsSheet.Cells[1, 8] = dgView.Rows[iFil].Cells[iCol].Value.ToString();
                        }

                    }

                    c = dgView.Rows[iFil].Cells[iCol].Style.BackColor; 
                    if (!c.IsEmpty)
                    {// COMPARAMOS SI ESTÁ PINTADA LA CELDA (SI ES VERDADERO PINTAMOS LA CELDA)
                        r = (Excel.Range)xlsSheet.Cells[iFil + 3, iCol + 1];
                        xlsSheet.get_Range(r, r).Interior.Color = System.Drawing.ColorTranslator.ToOle(dgView.Rows[iFil].Cells[iCol].Style.BackColor);
                        xlsSheet.Range[r, r].Font.Bold = true;
                    }
                    
                }
                //////pBar.Value += 1;
                columnas = iFil;
            }

            xlsSheet.Cells[columnas+5, 5] = "MAGRO ";
            xlsSheet.Cells[columnas + 6, 5] = Stf;
            xlsSheet.Cells[columnas + 5, 4] = "MERMA";
            xlsSheet.Cells[columnas + 6, 4] = porcent;

            xlsSheet.Columns.AutoFit();
            xlsSheet.PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape;
            xlsSheet.PageSetup.PaperSize = Excel.XlPaperSize.xlPaperLetter;
            xlsSheet.PageSetup.Zoom = 80;

            Excel.Range rango = xlsSheet.Range[xlsSheet.Cells[1, 1], xlsSheet.Cells[dgView.RowCount + 2, dgView.ColumnCount]];
            rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            rango.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);
            //////
            ///


            int iFil2 = 0, iCol2 = 0;
            foreach (DataGridViewColumn column in dgView2.Columns)
                if (column.Visible)
                    xlsSheet.Cells[columnas + 8, ++iCol2] = column.HeaderText;
            xlsSheet.Range[xlsSheet.Cells[columnas + 8, 1], xlsSheet.Cells[columnas + 8, dgView2.ColumnCount]].Font.Bold = true;
            xlsSheet.Range[xlsSheet.Cells[columnas + 8, 1], xlsSheet.Cells[columnas + 8, dgView2.ColumnCount]].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightSkyBlue);

            for (iFil2 = 0; iFil2 < dgView2.RowCount; iFil2++)
            {
                for (iCol2 = 0; iCol2 < dgView2.ColumnCount; iCol2++)
                {
                    xlsSheet.Cells[iFil2 + columnas + 9, iCol2 + 1] = dgView2.Rows[iFil2].Cells[iCol2].Value.ToString();
                    c = dgView2.Rows[iFil2].Cells[iCol2].Style.BackColor;
                    if (!c.IsEmpty)
                    {// COMPARAMOS SI ESTÁ PINTADA LA CELDA (SI ES VERDADERO PINTAMOS LA CELDA)
                        r = (Excel.Range)xlsSheet.Cells[iFil2 + columnas + 9, iCol + 1];
                        xlsSheet.get_Range(r, r).Interior.Color = System.Drawing.ColorTranslator.ToOle(dgView2.Rows[iFil2].Cells[iCol2].Style.BackColor);
                        xlsSheet.Range[r, r].Font.Bold = true;
                    }
                }
                //////pBar.Value += 1;
            }
            //xlsSheet.Columns.AutoFit();
            //xlsSheet.PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape;
            //xlsSheet.PageSetup.PaperSize = Excel.XlPaperSize.xlPaperLetter;
            //xlsSheet.PageSetup.Zoom = 80;

            Excel.Range rango2 = xlsSheet.Range[xlsSheet.Cells[columnas + 8, 1], xlsSheet.Cells[dgView2.RowCount + columnas + 8, dgView2.ColumnCount]];
            rango2.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            rango2.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);

            ////

            //rango.Cells.AutoFormat(Excel.XlRangeAutoFormat.xlRangeAutoFormatList1, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
            xlsApp.Visible = true;


        }




    }
}
