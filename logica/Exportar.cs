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
    public class Exportar
    {
        public void ExportarDataGridViewExcel(DataGridView dgView,string Fechad, string Fechah, string IngEgr, string Stf, string dif, string porcent,string desh, string dif2, string porcent2)
        {
            //////if (pBar != null)
            //////{
            //////    pBar.Maximum = dgView.RowCount;
            //////    pBar.Value = 0;
            //////    if (!pBar.Visible) pBar.Visible = true;
            //////}
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

            xlsSheet.Cells[1, 1] = "Balance MP Cárnica " + Fechad +" Al "+Fechah;
            //MARCAMOS LAS CELDAS DEL ENCABEZADO EN NEGRITA Y EN COLOR DE RELLENO GRIS
            xlsSheet.Range[xlsSheet.Cells[2, 1], xlsSheet.Cells[2, dgView.ColumnCount]].Font.Bold = true;
            xlsSheet.Range[xlsSheet.Cells[2, 1], xlsSheet.Cells[2, dgView.ColumnCount]].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightSkyBlue);

            xlsSheet.Cells[17, 2] = "S.Inicial + Ing - Egr: ";
            xlsSheet.Cells[18, 2] = IngEgr;
            xlsSheet.Cells[17, 3] = "StockFinal: ";
            xlsSheet.Cells[18, 3] = Stf;
            xlsSheet.Cells[17, 4] = "Diferencia";
            xlsSheet.Cells[18, 4] = dif;
            xlsSheet.Cells[18, 5] = porcent;

            Excel.Range r;
            Color c;
            for (iFil = 0; iFil < dgView.RowCount; iFil++)
            {
                for (iCol = 0; iCol < dgView.ColumnCount; iCol++)
                {
                    xlsSheet.Cells[iFil + 3, iCol + 1] = Convert.ToString(dgView.Rows[iFil].Cells[iCol].Value.ToString());
                    c = dgView.Rows[iFil].Cells[iCol].Style.BackColor; 
                    if (!c.IsEmpty)
                    {// COMPARAMOS SI ESTÁ PINTADA LA CELDA (SI ES VERDADERO PINTAMOS LA CELDA)
                        r = (Excel.Range)xlsSheet.Cells[iFil + 3, iCol + 1];
                        xlsSheet.get_Range(r, r).Interior.Color = System.Drawing.ColorTranslator.ToOle(dgView.Rows[iFil].Cells[iCol].Style.BackColor);
                        xlsSheet.Range[r, r].Font.Bold = true;
                    }
                }
                //////pBar.Value += 1;
            }
            xlsSheet.Columns.AutoFit();
            xlsSheet.PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape;
            xlsSheet.PageSetup.PaperSize = Excel.XlPaperSize.xlPaperLetter;
            xlsSheet.PageSetup.Zoom = 80;

            Excel.Range rango = xlsSheet.Range[xlsSheet.Cells[1, 1], xlsSheet.Cells[dgView.RowCount + 2, dgView.ColumnCount]];
            rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            rango.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);
            //rango.Cells.AutoFormat(Excel.XlRangeAutoFormat.xlRangeAutoFormatList1, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
            xlsApp.Visible = true;
        }


        public void ExportarDataGridViewExcelCC(DataGridView dgView, string codigo, string producto,  string Fechad, string Fechah)
        {
            ////////string sFont = "Verdana";
            ////////int iSize = 11;
            //CREACIÓN DE LOS OBJETOS DE EXCEL
            Excel.Application xlsApp = new Excel.Application();
            Excel.Worksheet xlsSheet;
            Excel.Workbook xlsBook;
            //AGREGAMOS EL LIBRO Y HOJA DE EXCEL
            xlsBook = xlsApp.Workbooks.Add(true);
            xlsSheet = (Excel.Worksheet)xlsBook.ActiveSheet;
            //ESPECIFICAMOS EL TIPO DE LETRA Y TAMAÑO DE LA LETRA DEL LIBRO
            //////xlsSheet.Rows.Cells.Font.Size = iSize;
            //////xlsSheet.Rows.Cells.Font.Name = sFont;
            xlsSheet.Cells.Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            //AGREGAMOS LOS ENCABEZADOS
            int iFil = 0, iCol = 0;
            foreach (DataGridViewColumn column in dgView.Columns)
                if (column.Visible)
                    xlsSheet.Cells[2, ++iCol] = column.HeaderText;

            xlsSheet.Cells[1, 1] = "FECHA DESDE: " + Fechad + "       HASTA: " + Fechah;
            xlsSheet.Cells[1, 2] = "Cod: "+codigo; xlsSheet.Cells[1, 3] = "Prod: "+producto;
            xlsSheet.Range[xlsSheet.Cells[1, 1], xlsSheet.Cells[2, dgView.ColumnCount]].Font.Bold = true;
            xlsSheet.Range[xlsSheet.Cells[1, 1], xlsSheet.Cells[2, dgView.ColumnCount]].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightSkyBlue);
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

                    if (iCol == 0)
                    {
                        DateTime fecha = Convert.ToDateTime(dgView.Rows[iFil].Cells[iCol].Value.ToString());
                        xlsSheet.Cells[iFil + 3, iCol + 1] = Convert.ToString(fecha.ToString("dd/MMMM/yyyy"));
                        //xlsSheet.Cells[iFil + 3, iCol + 1] = dgView.Rows[iFil].Cells[iCol].Value.ToString();
                    }
                    else
                    {
                        xlsSheet.Cells[iFil + 3, iCol + 1] = dgView.Rows[iFil].Cells[iCol].Value.ToString();
                    }
                    c = dgView.Rows[iFil].Cells[iCol].Style.BackColor;
                    if (!c.IsEmpty)
                    {// COMPARAMOS SI ESTÁ PINTADA LA CELDA (SI ES VERDADERO PINTAMOS LA CELDA)
                        r = (Excel.Range)xlsSheet.Cells[iFil + 3, iCol + 1];
                        xlsSheet.get_Range(r, r).Interior.Color = System.Drawing.ColorTranslator.ToOle(dgView.Rows[iFil].Cells[iCol].Style.BackColor);
                        xlsSheet.Range[r, r].Font.Bold = true;
                    }
                }
            }
            xlsSheet.Columns.AutoFit();
            xlsSheet.PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape;
            xlsSheet.PageSetup.PaperSize = Excel.XlPaperSize.xlPaperLetter;
            xlsSheet.PageSetup.Zoom = 80;

            Excel.Range rango = xlsSheet.Range[xlsSheet.Cells[1, 1], xlsSheet.Cells[dgView.RowCount + 2, dgView.ColumnCount]];
            rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            rango.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);
            //rango.Cells.AutoFormat(Excel.XlRangeAutoFormat.xlRangeAutoFormatList1, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
            xlsApp.Visible = true;
        }
        public void ExportarDataGridViewExcelIng(DataGridView dgView, string grupo, string proveedor,string producto, string Fechad, string Fechah)
        {
            ////////string sFont = "Verdana";
            ////////int iSize = 11;
            //CREACIÓN DE LOS OBJETOS DE EXCEL
            Excel.Application xlsApp = new Excel.Application();
            Excel.Worksheet xlsSheet;
            Excel.Workbook xlsBook;
            //AGREGAMOS EL LIBRO Y HOJA DE EXCEL
            xlsBook = xlsApp.Workbooks.Add(true);
            xlsSheet = (Excel.Worksheet)xlsBook.ActiveSheet;
            //ESPECIFICAMOS EL TIPO DE LETRA Y TAMAÑO DE LA LETRA DEL LIBRO
            //////xlsSheet.Rows.Cells.Font.Size = iSize;
            //////xlsSheet.Rows.Cells.Font.Name = sFont;
            xlsSheet.Cells.Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            //AGREGAMOS LOS ENCABEZADOS
            int iFil = 0, iCol = 0;
            foreach (DataGridViewColumn column in dgView.Columns)
               // if (column.Visible)
                    xlsSheet.Cells[2, ++iCol] = column.HeaderText;

            xlsSheet.Cells[1, 1] = "FECHA DESDE: " + Fechad + "       HASTA: " + Fechah;
            xlsSheet.Cells[1, 2] = "GRUPO: " + grupo;  xlsSheet.Cells[1, 6] = "Prov: "+proveedor; xlsSheet.Cells[1, 10] = "Prod: "+producto;
            xlsSheet.Range[xlsSheet.Cells[1, 1], xlsSheet.Cells[2, dgView.ColumnCount]].Font.Bold = true;
            xlsSheet.Range[xlsSheet.Cells[1, 1], xlsSheet.Cells[2, dgView.ColumnCount]].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightSkyBlue);
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
                    if (iCol == 1)
                    {
                        DateTime fecha = Convert.ToDateTime(dgView.Rows[iFil].Cells[iCol].Value.ToString());
                        xlsSheet.Cells[iFil + 3, iCol + 1] = Convert.ToString(fecha.ToString("dd/MMMM/yyyy"));
                        //xlsSheet.Cells[iFil + 3, iCol + 1] = dgView.Rows[iFil].Cells[iCol].Value.ToString();
                    }
                    else
                    {

                        xlsSheet.Cells[iFil + 3, iCol + 1] = dgView.Rows[iFil].Cells[iCol].Value.ToString();
                    }
                        c = dgView.Rows[iFil].Cells[iCol].Style.BackColor;
                        if (!c.IsEmpty)
                        {// COMPARAMOS SI ESTÁ PINTADA LA CELDA (SI ES VERDADERO PINTAMOS LA CELDA)
                            r = (Excel.Range)xlsSheet.Cells[iFil + 3, iCol + 1];
                            xlsSheet.get_Range(r, r).Interior.Color = System.Drawing.ColorTranslator.ToOle(dgView.Rows[iFil].Cells[iCol].Style.BackColor);
                            xlsSheet.Range[r, r].Font.Bold = true;
                        }
                    
                }
            }
            xlsSheet.Columns.AutoFit();
            xlsSheet.PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape;
            xlsSheet.PageSetup.PaperSize = Excel.XlPaperSize.xlPaperLetter;
            xlsSheet.PageSetup.Zoom = 80;

            Excel.Range rango = xlsSheet.Range[xlsSheet.Cells[1, 1], xlsSheet.Cells[dgView.RowCount + 2, dgView.ColumnCount]];
            rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            rango.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);
            //rango.Cells.AutoFormat(Excel.XlRangeAutoFormat.xlRangeAutoFormatList1, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
            xlsApp.Visible = true;
        }



    }
}
