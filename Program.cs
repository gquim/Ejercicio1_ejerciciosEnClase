// See https://aka.ms/new-console-template for more information

//

Console.WriteLine("Ingresar numeros del 1 al 12");
int mes=Convert.ToInt32( Console.ReadLine()) ;

string nombreMes;

switch(mes)
{
    case 1: nombreMes="enero"; break;
    case 2: nombreMes = "febrero"; break;
    case 3: nombreMes = "marzo"; break;
    case 4: nombreMes = "abril"; break;
    case 5: nombreMes = "mayo"; break;
    case 6: nombreMes = "junio"; break;
    case 7: nombreMes = "julio"; break;
    case 8: nombreMes = "agosto"; break;
    case 9: nombreMes = "septiembre"; break;
    case 10: nombreMes = "octubre"; break;
    case 11: nombreMes = "noviembre"; break;
    case 12: nombreMes = "diciembre"; break;
     default: Console.WriteLine("no hay mes con esa numeracion"); return;
}
Console.WriteLine("El mes correspondiente es: " + nombreMes);