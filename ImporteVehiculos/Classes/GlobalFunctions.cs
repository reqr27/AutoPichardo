using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace ImporteVehiculos.Classes
{
    class GlobalFunctions
    {
        public string ValidarCampoString(string[] valores)
        {
            string msj = "OK";
            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i].Trim() == "")
                {
                    msj = "Favor completar todos los campos";
                    break;
                }
            }
            return msj;
        }

        public string ValidarCampoNumerico(string[] valores)
        {
            string msj = "OK";
            double n;

            for (int i = 0; i < valores.Length; i++)
            {
                bool Num = double.TryParse(valores[i].ToString(), out n);
                if (!Num)
                {
                    msj = "Los campos numéricos no permiten letras";
                }
            }
            return msj;
        }

        public string serial()
        {

            //wmic diskdrive get serialnumber
            ManagementClass mangnmt = new ManagementClass("Win32_DiskDrive");
            ManagementObjectCollection mcol = mangnmt.GetInstances();
            string result = "";

            foreach (ManagementObject strt in mcol)
            {
                if (Convert.ToString(strt["MediaType"]).ToUpper().Contains("FIXED"))
                {
                    result += Convert.ToString(strt["SerialNumber"]);
                }
            }
            string time = DateTime.Now.ToString("yyyyMM");

            return time.Trim() + result.Trim();
        }

        public List<string> GetArrayofYears()
        {
            List<String> years = new List<String>();
            var myDate = DateTime.Now.Year;
            var minDate = myDate - 20;
            if (DateTime.Now.Month >= 7)
            {
                myDate = DateTime.Now.Year + 1;
                minDate = myDate - 11;
            }
            
            
            for (int i = minDate; i <= myDate; i++)
            {
                years.Add(i.ToString());
            }

            return years;
        }

        public bool ValidarPermisoTransaccion(string transaccion)
        {
            bool acceso = false;
            Procedimientos P = new Procedimientos();
            DataTable dt = new DataTable();
            P.Id = Program.GidUsuario;
            dt = P.ObtenerPermisosUsuario();
            if (Convert.ToBoolean(dt.Rows[0]["ESTADO USUARIO"]))
            {
                if (transaccion == "CREAR USUARIOS")
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["CREAR USUARIOS"]);
                }
                else if (transaccion == "TASA CAMBIO")
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["TASA CAMBIO"]);
                }

                else if (transaccion == "CREAR FABRICANTES/MODELOS")
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["CREAR FABRICANTES/MODELOS"]);
                }

                else if (transaccion == "CREAR PIEZAS/REPUESTOS")
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["CREAR PIEZAS/REPUESTOS"]);
                }
                else if (transaccion == "CREAR TALLER")
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["CREAR TALLER"]);
                }

                else if (transaccion == "CREAR PROPIETARIOS")
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["CREAR PROPIETARIOS"]);
                }

                else if (transaccion == "CREAR CLIENTES")
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["CREAR CLIENTES"]);
                }

                else if (transaccion == "CREAR GASTOS")
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["CREAR GASTOS"]);
                }

                else if (transaccion == "IMPORTAR VEHICULOS")
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["IMPORTAR VEHICULOS"]);
                }

                else if (transaccion == "COMPRAS")
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["COMPRAS"]);
                }

                else if (transaccion == "CAMBIAR ESTADO VEHICULOS")
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["CAMBIAR ESTADO VEHICULOS"]);
                }

                else if (transaccion == "AGREGAR GASTO A VEHICULO")
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["AGREGAR GASTO A VEHICULO"]);
                }

                else if (transaccion == "AGREGAR PIEZAS A VEHICULO")
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["AGREGAR PIEZAS A VEHICULO"]);
                }

                else if (transaccion == "REPORTES")
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["REPORTES"]);
                }

                else if ((transaccion == "FACTURACION"))
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["FACTURACION"]);
                }

                else if ((transaccion == "MODIFICAR VEHICULO"))
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["MODIFICAR VEHICULO"]);
                }

                else if ((transaccion == "CUENTAS COBRAR"))
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["CUENTAS COBRAR"]);
                }

                else if ((transaccion == "CUENTAS PAGAR"))
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["CUENTAS PAGAR"]);
                }

                else if ((transaccion == "ACTUALIZAR TASA DIARIO"))
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["ACTUALIZAR TASA DIARIO"]);
                }

                else if ((transaccion == "AGREGAR PAISES"))
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["AGREGAR PAISES"]);
                }

                else if ((transaccion == "AGREGAR CIUDADES"))
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["AGREGAR CIUDADES"]);
                }

                else if ((transaccion == "AGREGAR COLORES"))
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["AGREGAR COLORES"]);
                }

                else if ((transaccion == "AGREGAR SUPLIDORES"))
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["AGREGAR SUPLIDORES"]);
                }

                else if ((transaccion == "AGREGAR UBICACIONES"))
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["AGREGAR UBICACIONES"]);
                }

                else if ((transaccion == "AGREGAR SEGUROS"))
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["AGREGAR SEGUROS"]);
                }

                else if ((transaccion == "AGREGAR CUENTAS ANTIGUAS"))
                {
                    acceso = Convert.ToBoolean(dt.Rows[0]["AGREGAR CUENTAS ANTIGUAS"]);
                }
            }


            return acceso;
        }

        public bool serialKeyActivation(int total)
        {
            bool activated = false;
            int totalSumSerial = 10000 + Convert.ToInt16(DateTime.Now.Day) + Convert.ToInt16(DateTime.Now.Month) + Convert.ToInt16(DateTime.Now.Year);
            if(totalSumSerial == total)
            {
                activated = true;
            }
            return activated;
        }
    }

}
