using System.Timers;
using Guia_de_Ejercicios1.Bloque1;
using Guia_de_Ejercicios1.Bloque2;
using Guia_de_Ejercicios1.Bloque3;
using Guia_de_Ejercicios1.Bloque4;
using Guia_de_Ejercicios1.Bloque5;

int opcion;
     
 do
{
        MostrarMenu();
        while (!int.TryParse(Console.ReadLine(), out opcion))
        {
            Console.WriteLine("****Valor invalido, ingrese su opcion****");
        }

        if (opcion < 0 || opcion > 30)
        {
            Console.WriteLine("\n*****ingrese una opcion entre 0-30*****\n");
            continue;
        }

        if (opcion == 0)
        {
            Console.WriteLine("Saliendo del programa..........");
            Environment.Exit(0);
        }

        Console.Clear();

    int salida;

    do
    {
        switch(opcion)
        {
//---------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------
        case 1:
        float peso = LeerFloatPositivo("Ingrese el peso: ");
        float altura = LeerFloatPositivo("Ingrese la altura: ");

        CalculadoradeIMC calculadora = new CalculadoradeIMC();

        float resultado = calculadora.IMC(peso, altura);
        string categoria = calculadora.Clasificación(resultado);

        Console.WriteLine("El indice de masa corporal es: " + resultado);
        Console.WriteLine("Clasificacion: " + categoria);

        
        break;
//---------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------
        case 2:
        int tipo;

        do
        {
            Console.WriteLine("Selecione el tipo de temperatura: ");
            Console.WriteLine("1. Celsius");
            Console.WriteLine("2. Farenheit");
            Console.WriteLine("3. Kelvin");

        } while (!int.TryParse(Console.ReadLine(), out tipo) || tipo < 1 || tipo > 3 );

        float valor = LeerFloat("Ingrese la temperatura: ");

            switch (tipo)
            {
                case 1://si el usuario ingreso grados celsius
                Console.WriteLine("Farenheit: " + ConversorTemperatura.CF(valor));
                Console.WriteLine("Kelvin: " + ConversorTemperatura.CK(valor));
                break;
                
                case 2://si el usuario ingreso grados farenheit
                Console.WriteLine("Celsius: " + ConversorTemperatura.FC(valor));
                Console.WriteLine("Kelvin: " + ConversorTemperatura.FK(valor));
                break;

                case 3://si el usuario ingreso grados Kelvin
                Console.WriteLine("Celsius: " + ConversorTemperatura.KC(valor));
                Console.WriteLine("Farenheit: " + ConversorTemperatura.KF(valor));
                break;
            }

        break;
//---------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------
        case 3:

        int monto = (int)LeerFloatPositivo("Ingrese el monto en lempiras: ");

        DesglosadorBilletes.MostrarDesglose(monto);
        break;

        case 4:
        float Monto = LeerFloatPositivo("Ingrese el monto del prestamo: ");
        float tasa = LeerFloatPositivo("Ingrese la tasa de interes anual (%): ");
        float plazo = LeerFloatPositivo("Ingrese el plazo en meses: ");

        float interesTotal = CalculadoraPrestamo.CalculadoraInteresTotal(Monto, tasa, plazo);
        float CuotaMensual = CalculadoraPrestamo.CalculadoraCuotaMensual(Monto, interesTotal, plazo);

        Console.WriteLine("\n---Resumen del prestamo---");
        Console.WriteLine("Monto solicitado: L. " + Monto);
        Console.WriteLine("Interes total a pagar : L." + interesTotal);
        Console.WriteLine("Cuota mensual fija: L. " + CuotaMensual);
        Console.WriteLine("Total final a pagar: L. " + (Monto + interesTotal));
        break;
//---------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------
        case 5:
        Console.WriteLine("---Primera Hora---");
        int h1 = LeerEntero("Hora (0-23): ");
        int m1 = LeerEntero("Minutos (0-59): ");
        int s1 = LeerEntero("Segundos (0-59): ");

        Console.WriteLine("---Segunda Hora---");
        int h2 = LeerEntero("Hora (0-23): ");
        int m2 = LeerEntero("Minutos (0-59): ");
        int s2 = LeerEntero("Segundos (0-59): ");

        CalculadoraTiempo.CalculadoraDiferencia(h1, m1, s1, h2, m2, s2);
        break;
//---------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------
        case 6:
            Console.WriteLine("--- CALCULADORA GEOMÉTRICA ---");
            Console.WriteLine("1. Circulo");
            Console.WriteLine("2. Triangulo (Equilatero)");
            Console.WriteLine("3. Rectangulo");
            Console.WriteLine("4. Trapecio");
            int opcionArea = (int)LeerFloatPositivo("Seleccione una figura: ");

            switch (opcionArea)
            {
            case 1:
                double radio = LeerFloatPositivo("Ingrese el radio: ");
                Console.WriteLine("Area: " + Geometria.AreaCirculo(radio));
                Console.WriteLine("Perimetro: " + Geometria.PerimetroCirculo(radio));
            break;

            case 2:
                double baseT = LeerFloatPositivo("Ingrese la base: ");
                double alturaT = LeerFloatPositivo("Ingrese la altura: ");
                Console.WriteLine("Area: " + Geometria.AreaTriangulo(baseT, alturaT));
                Console.WriteLine("Perimetro (si fuera equilatero): " + Geometria.PerimetroTrianguloEquilatero(baseT));
            break;

            case 3:
                double baseR = LeerFloatPositivo("Ingrese la base: ");
                double alturaR = LeerFloatPositivo("Ingrese la altura: ");
                Console.WriteLine("Area: " + Geometria.AreaRectangulo(baseR, alturaR));
                Console.WriteLine("Perimetro: " + Geometria.PerimetroRectangulo(baseR, alturaR));
                break;

            case 4:
                double baseMayor = LeerFloatPositivo("Base Mayor: ");
                double baseMenor = LeerFloatPositivo("Base Menor: ");
                double alturaTra = LeerFloatPositivo("Altura: ");
                double lado1c4 = LeerFloatPositivo("Lado lateral 1: ");
                double lado2c4 = LeerFloatPositivo("Lado lateral 2: ");
                Console.WriteLine("Area: " + Geometria.AreaTrapecio(baseMayor, baseMenor, alturaTra));
                Console.WriteLine("Perimetro: " + Geometria.PerimetroTrapecio(baseMayor, baseMenor, lado1c4, lado2c4));
                break;

            default:
            Console.WriteLine("Opcion no valida.");
            break;
            }
        break;
//---------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------
        case 7:
            Console.WriteLine("--- CONVERSOR DE ALMACENAMIENTO ---");
            Console.WriteLine("1. Bytes\n2. KB\n3. MB\n4. GB\n5. TB");

            int origen = (int)LeerFloatPositivo("Seleccione la unidad de ORIGEN: ");
            int destino = (int)LeerFloatPositivo("Seleccione la unidad de DESTINO: ");

            if (origen >= 1 && origen <= 5 && destino >= 1 && destino <= 5)
            {
                float cantidad = LeerFloatPositivo("Ingrese la cantidad a convertir: ");
                
                double Resultado = ConversorAlmacenamiento.Convertir(cantidad, origen, destino);
                
                // Uso de concatenación tradicional con el signo +
                Console.WriteLine("\nResultado: " + cantidad + " " + ConversorAlmacenamiento.ObtenerNombreUnidad(origen) + " equivalen a " + Resultado + " " + ConversorAlmacenamiento.ObtenerNombreUnidad(destino));
            }
            
            else
            {
                Console.WriteLine("Opciones de unidad no válidas.");
            }
        break;
//---------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------
        case 8:
            Console.WriteLine("--- CÁLCULO DE PLANILLA SEMANAL ---");

            float horasTrabajadas = LeerFloatPositivo("Ingrese las horas trabajadas en la semana: ");
            float tarifaPorHora = LeerFloatPositivo("Ingrese el pago por hora (tarifa): ");

            // Realizar cálculos llamando a la clase
            double pagoNormal = CalculadoraSalario.CalcularPagoNormal(horasTrabajadas, tarifaPorHora);
            double pagoExtra = CalculadoraSalario.CalcularPagoExtra(horasTrabajadas, tarifaPorHora);
            double cantExtras = CalculadoraSalario.ObtenerCantidadExtras(horasTrabajadas);
            double total = pagoNormal + pagoExtra;

            // Mostrar desglose usando concatenación tradicional
            Console.WriteLine("\n--- DESGLOSE DE PAGO ---");
            Console.WriteLine("Horas normales pagadas: " + (horasTrabajadas > 44 ? 44 : horasTrabajadas));
            Console.WriteLine("Horas extras detectadas: " + cantExtras);
            Console.WriteLine("Pago base: L. " + pagoNormal);
            Console.WriteLine("Pago por horas extras (150%): L. " + pagoExtra);
            Console.WriteLine("------------------------------");
            Console.WriteLine("SALARIO TOTAL SEMANAL: L. " + total);
        break;
//---------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------
        case 9:
            Console.WriteLine("--- CLASIFICADOR DE TRIÁNGULOS ---");

            float lado1 = LeerFloatPositivo("Ingrese el primer lado: ");
            float lado2 = LeerFloatPositivo("Ingrese el segundo lado: ");
            float lado3 = LeerFloatPositivo("Ingrese el tercer lado: ");

            if (ValidadorTriangulo.EsValido(lado1, lado2, lado3))
            {
                string porLados = ValidadorTriangulo.ClasificarPorLados(lado1, lado2, lado3);
                string porAngulos = ValidadorTriangulo.ClasificarPorAngulos(lado1, lado2, lado3);

                Console.WriteLine("\nRESULTADOS:");
                Console.WriteLine("Es un triangulo valido.");
                Console.WriteLine("Tipo por sus lados: " + porLados);
                Console.WriteLine("Tipo por sus angulos: " + porAngulos);
            }
            else
            {
                Console.WriteLine("\nERROR: Los lados ingresados no pueden formar un triangulo.");
                Console.WriteLine("Recuerde: La suma de dos lados debe ser mayor al tercero.");
            }
        break;
//---------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------
        case 10:
            Console.WriteLine("---SISTEMA DE CALIFICACIONES---");

            //validacion de nota entre 0 y 100
            float nota;
            do
            {
                nota = LeerFloat("ingrese la nota final de (0-100): ");
                if (nota < 0 || nota > 100)
                {
                    Console.WriteLine("Error: La nota debe estar en el rango de 0 a 100.");
                }
            } while (nota < 0 || nota > 100);

            string letra = CalculadoraNotas.ObtenerLetra(nota);
            string desc = CalculadoraNotas.ObtenerDescripcion(letra);
            string estado = CalculadoraNotas.ObtenerEstado(nota);

            Console.WriteLine("\n---RESULTADO FINAL---");
            Console.WriteLine("Nota Numerica: " + nota + "%");
            Console.WriteLine("Calificacion: " + letra);
            Console.WriteLine("Descripcion: " + desc);
            Console.WriteLine("Estado del estudiante: " + estado);

        break;
//---------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------
        case 11:
            Console.WriteLine("--- CALCULADORA DE DESCUENTOS ---");

            float montoCompra = LeerFloatPositivo("Ingrese el monto de la compra: L. ");

            // Obtener datos de la clase de lógica
            float porcentaje = ProcesadorDescuentos.ObtenerPorcentaje(montoCompra);
            float descuentoRecibido = ProcesadorDescuentos.CalcularDescuento(montoCompra, porcentaje);
            float totalAPagar = ProcesadorDescuentos.CalcularTotalFinal(montoCompra, descuentoRecibido);

            // Mostrar resultados usando concatenación tradicional
            Console.WriteLine("\n--- RESUMEN DE COMPRA ---");
            Console.WriteLine("Precio original: L. " + montoCompra);
            Console.WriteLine("Porcentaje aplicado: " + (porcentaje * 100) + "%");
            Console.WriteLine("Descuento aplicado: L. " + descuentoRecibido);
            Console.WriteLine("------------------------------");
            Console.WriteLine("PRECIO FINAL A PAGAR: L. " + totalAPagar);
        break;
//---------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------
        case 12:
            Console.WriteLine("--- CONSULTA DE DÍAS DEL MES ---");

            int anio = (int)LeerFloatPositivo("Ingrese el año (ej. 2024): ");
            int mes;

            // Validación específica para el rango de meses
            do
            {
                mes = (int)LeerFloatPositivo("Ingrese el número del mes (1-12): ");
                if (mes < 1 || mes > 12)
                {
                    Console.WriteLine("Error: El mes debe estar entre 1 y 12.");
                }
            } while (mes < 1 || mes > 12);

            // Obtener datos de la clase
            bool bisiesto = Calendario.EsBisiesto(anio);
            int dias = Calendario.ObtenerDiasDelMes(mes, anio);
            string nombre = Calendario.NombreMes(mes);

            // Mostrar resultados con concatenación tradicional (+)
            Console.WriteLine("\n--- RESULTADO ---");
            Console.WriteLine("Año: " + anio);
            Console.WriteLine("¿Es bisiesto?: " + (bisiesto ? "SÍ" : "NO"));
            Console.WriteLine("Mes: " + nombre);
            Console.WriteLine("Cantidad de días: " + dias + " días.");
        break;
//---------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------
        case 13:
            Console.WriteLine("--- VALIDADOR DE FECHAS ---");

            int dia = (int)LeerFloat("Ingrese el dia: ");
            int mesc13 = (int)LeerFloat("Ingrese el mes: ");
            int anioc13 = (int)LeerFloat("Ingrese el año: ");
//---------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------
            bool resultadoc13 = ValidadorFecha.EsFechaValida(dia, mesc13, anioc13);

            Console.WriteLine("\n--- RESULTADO ---");
            Console.WriteLine("Fecha ingresada: " + dia + "/" + mesc13 + "/" + anioc13);

            if (resultadoc13)
            {
                Console.WriteLine("Estado: La fecha es VALIDA.");
            }
            else
            {
                Console.WriteLine("Estado: La fecha es INVALIDA.");
                Console.WriteLine("Explicacion: El dia no corresponde al mes o el año ingresado.");
        }
 
        break;
//---------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------
        case 14:
                        Console.WriteLine("--- CAJERO AUTOMÁTICO ---");
            Console.WriteLine("Saldo disponible: L. " + LogicaCajero.ConsultarSaldo());

            float montoRetiro = LeerFloatPositivo("Ingrese el monto a retirar (multiplos de 20): ");

            // 1. Verificar que sea múltiplo de 20
            if (!LogicaCajero.EsMultiploDe20(montoRetiro))
            {
                Console.WriteLine("Error: El cajero solo entrega billetes de L. 20 en adelante. El monto debe ser multiplo de 20.");
            }
            // 2. Verificar que no exceda el saldo
            else if (!LogicaCajero.TieneSaldoSuficiente(montoRetiro))
            {
                Console.WriteLine("Error: Fondos insuficientes. Su saldo es de L. " + LogicaCajero.ConsultarSaldo());
            }
            // 3. Procesar el retiro
            else
            {
                LogicaCajero.ProcesarRetiro(montoRetiro);
                Console.WriteLine("Saldo restante: L. " + LogicaCajero.ConsultarSaldo());
            }

        break;
//---------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------
        case 15:
            Console.WriteLine("--- TABLA DE MULTIPLICAR ---");

            int num = (int)LeerFloatPositivo("¿De qué número desea la tabla?: ");

            Console.WriteLine("\nTabla del " + num + ":");
            Console.WriteLine("------------------------");

            // Ciclo del 1 al 12
            for (int i = 1; i <= 12; i++)
            {
                // Llamamos a la clase para obtener la línea formateada
                string linea = LogicaTablas.ObtenerLineaTabla(num, i);
                Console.WriteLine(linea);
            }

            Console.WriteLine("------------------------");
        break;
//---------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------
        case 16:
            Console.WriteLine("--- BUSCADOR DE NÚMEROS PRIMOS ---");

            int inicio = (int)LeerFloat("Ingrese el inicio del rango: ");
            int fin = (int)LeerFloat("Ingrese el fin del rango: ");
             // Asegurar que el inicio sea menor que el fin para el ciclo
            if (inicio > fin)
            {
                int temp = inicio;
                inicio = fin;
                fin = temp;
            }

            int contadorPrimos = 0;
            string listaPrimos = "";

            Console.WriteLine("\nAnalizando rango desde " + inicio + " hasta " + fin + "...");

            for (int i = inicio; i <= fin; i++)
            {
                if (CalculadorPrimos.EsPrimo(i))
                {
                    // Concatenamos el número encontrado a nuestra lista
                    listaPrimos = listaPrimos + i + " ";
                    contadorPrimos = contadorPrimos + 1;
                }
            }

            // Mostrar resultados con concatenación tradicional
            Console.WriteLine("\nNumeros primos encontrados:");
            Console.WriteLine(listaPrimos == "" ? "No se encontraron primos." : listaPrimos);
            Console.WriteLine("\nTotal de numeros primos en el rango: " + contadorPrimos);
        break;
//---------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------
        case 17:
            Console.WriteLine("--- SERIE DE FIBONACCI ---");

            int n = (int)LeerFloatPositivo("¿Cuantos terminos desea generar?: ");

            if (n > 0)
            {
                long sumaTotal = 0;
                string serieCompleta = "";

                Console.WriteLine("\nGenerando " + n + " terminos:");

                for (int i = 0; i < n; i++)
                {
                    long terminoActual = CalculadorFibonacci.ObtenerTermino(i);
                    sumaTotal = sumaTotal + terminoActual;
                    
                    // Concatenamos el término a la cadena de texto
                    serieCompleta = serieCompleta + terminoActual + (i < n - 1 ? ", " : "");
                }

                double promedio = (double)sumaTotal / n;

                // Mostrar resultados con concatenación
                Console.WriteLine(serieCompleta);
                Console.WriteLine("------------------------------");
                Console.WriteLine("Suma total: " + sumaTotal);
                Console.WriteLine("Promedio: " + promedio);
            }
            else
            {
                Console.WriteLine("Debe ingresar un numero mayor a 0.");
            }
        break;
//---------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------
        case 18:
            Console.WriteLine("--- CALCULADORA DE FACTORIAL Y COMBINACIONES ---");

            // Parte 1: Calcular un factorial simple
            int numFactorial = (int)LeerFloatPositivo("Ingrese un numero para calcular su factorial (n!): ");
            double resultadoFact = CalculadoraFactorial.CalcularFactorial(numFactorial);
            Console.WriteLine("El factorial de " + numFactorial + " es: " + resultadoFact);

            Console.WriteLine("\n--- CALCULO DE COMBINATORIA C(n, r) ---");

            // Parte 2: Calcular combinaciones
            int N = (int)LeerFloatPositivo("Ingrese el valor total de elementos (n): ");
            int r;

            do {
                r = (int)LeerFloatPositivo("Ingrese el numero de elementos a elegir (r): ");
                if (r > N)
                {
                    Console.WriteLine("Error: 'r' no puede ser mayor que 'n'.");
                }
            } while (r > N);

            double resultadoComb = CalculadoraFactorial.CalcularCombinacion(N, r);

            // Mostrar resultados con concatenación tradicional
            Console.WriteLine("\nRESULTADO:");
            Console.WriteLine("Combinaciones posibles de " + N + " en " + r + " es: " + resultadoComb);
        break;
//---------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------
        case 19:
            Console.WriteLine("--- JUEGO DE ADIVINANZA ---");
            Console.WriteLine("He pensado un numero entre 1 y 100. Tienes 7 intentos para adivinarlo.");

            JuegoAdivinanza.IniciarJuego();

            int intentosMaximos = 7;
            int intentosRealizados = 0;
            bool adivino = false;
            int intentoUsuario;

            while (intentosRealizados < intentosMaximos && !adivino)
            {
                intentosRealizados = intentosRealizados + 1;
                
                intentoUsuario = (int)LeerFloat("Intento " + intentosRealizados + "/" + intentosMaximos + " - Ingrese su numero: ");

                string resultadoc19 = JuegoAdivinanza.VerificarIntento(intentoUsuario);

                if (resultadoc19 == "CORRECTO")
                {
                    adivino = true;
                }
                else
                {
                    Console.WriteLine("Pista: El numero secreto es " + resultadoc19 + " que " + intentoUsuario);
                }
            }

            // Estadísticas finales
            Console.WriteLine("\n--- FIN DEL JUEGO ---");
            if (adivino)
            {
                Console.WriteLine("¡FELICIDADES! Adivinaste el numero en " + intentosRealizados + " intentos.");
            }
            else
            {
                Console.WriteLine("Lo siento, te has quedado sin intentos.");
                Console.WriteLine("El numero secreto era: " + JuegoAdivinanza.ObtenerNumeroSecreto());
            }
        break;
//---------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------
        case 20:
            Console.WriteLine("--- CREACIÓN DE CONTRASEÑA SEGURA ---");

            string password = "";
            string errores = "";
            bool esValida = false;

            do
            {
                Console.Write("\nIngrese su nueva contraseña: ");
                password = Console.ReadLine() ?? "";

                // Obtenemos los requisitos que faltan
                errores = ValidadorSeguridad.VerificarRequisitos(password);

                if (errores == "")
                {
                    esValida = true;
                    Console.WriteLine("\n¡Contraseña aceptada! Su cuenta ha sido protegida.");
                }
                else
                {
                    Console.WriteLine("\nLa contraseña no es segura. Falta lo siguiente:");
                    // Concatenacion tradicional
                    Console.WriteLine(errores);
                    Console.WriteLine("Intente de nuevo.");
                }

            } while (esValida == false);

            Console.WriteLine("Presione cualquier tecla para terminar...");
            Console.ReadKey();
        break;
//---------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------
        case 21:
            Console.WriteLine("--- GENERADOR DE PATRONES ---");
            Console.WriteLine("1. Triangulo");
            Console.WriteLine("2. Triangulo Invertido");
            Console.WriteLine("3. Cuadrado Hueco");
            Console.WriteLine("4. Rombo");

            int opcionc21 = (int)LeerFloat("Seleccione una opcion: ");
            int tamano = (int)LeerFloat("Ingrese el tamaño del patron: ");

            string patronGenerado = "";

            switch (opcionc21)
            {
                case 1:
                    patronGenerado = GeneradorPatrones.Triangulo(tamano);
                    break;
                case 2:
                    patronGenerado = GeneradorPatrones.TrianguloInvertido(tamano);
                    break;
                case 3:
                    patronGenerado = GeneradorPatrones.CuadradoHueco(tamano);
                    break;
                case 4:
                    patronGenerado = GeneradorPatrones.Rombo(tamano);
                    break;
                default:
                    Console.WriteLine("Opcion no valida.");
                    break;
            }

            Console.WriteLine("\nRESULTADO:\n");
            Console.WriteLine(patronGenerado);
        break;
//---------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------       
        case 22:
            int opcionc22 = 0;
            
            do
            {
                Console.WriteLine("\n--- CALCULADORA ---");
                Console.WriteLine("Resultado actual: " + Calculadora.ObtenerResultado());
                Console.WriteLine("1. Sumar\n2. Restar\n3. Multiplicar\n4. Dividir");
                Console.WriteLine("5. Potencia\n6. Raiz Cuadrada\n7. Porcentaje\n8. Limpiar (C)\n9. Salir");

                

                opcionc22 = (int)LeerFloat("Seleccione operacion: ");

                if (opcionc22 >= 1 && opcionc22 <= 7)
                {
                    // Si es la primera vez o limpiamos, pedimos un número base
                    if (Calculadora.ObtenerResultado() == 0 && opcionc22 != 6)
                    {
                        float inicial = LeerFloat("Ingrese el numero inicial: ");
                        Calculadora.EstablecerResultado(inicial);
                    }

                    if (opcionc22 == 6) // Raíz cuadrada no necesita segundo número
                    {
                        Calculadora.RaizCuadrada();
                    }
                    else
                    {
                        float numc22 = LeerFloat("Ingrese el valor: ");
                        switch (opcionc22)
                        {
                            case 1: Calculadora.Sumar(numc22); break;
                            case 2: Calculadora.Restar(numc22); break;
                            case 3: Calculadora.Multiplicar(numc22); break;
                            case 4: Calculadora.Dividir(numc22); break;
                            case 5: Calculadora.Potencia(numc22); break;
                            case 7: Calculadora.AplicarPorcentaje(numc22); break;
                        }
                    }
                }
                else if (opcionc22 == 8)
                {
                    Calculadora.Limpiar();
                    Console.WriteLine("Calculadora reiniciada.");
                }

            } while (opcionc22 != 9);

            Console.WriteLine("Gracias por usar la calculadora. ¡Adios!");
        break;
//---------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------
        case 23:
            Console.WriteLine("--- ESTADÍSTICAS DE CALIFICACIONES ---");

            int cantidadNotas = (int)LeerFloat("¿Cuántas notas desea ingresar?: ");

            // Creamos el arreglo con el tamaño definido por el usuario
            float[] notasArreglo = new float[cantidadNotas];

            for (int indiceNota = 0; indiceNota < cantidadNotas; indiceNota = indiceNota + 1)
            {
                float notaIngresada;
                do {
                    notaIngresada = LeerFloat("Ingrese la nota " + (indiceNota + 1) + " (0-100): ");
                    if (notaIngresada < 0 || notaIngresada > 100)
                    {
                        Console.WriteLine("Error: La nota debe estar entre 0 y 100.");
                    }
                } while (notaIngresada < 0 || notaIngresada > 100);
                
                notasArreglo[indiceNota] = notaIngresada;
            }

            // Procesar con la clase
            float promFinal = EstadisticoNotas.CalcularPromedio(notasArreglo);
            float notaMax = EstadisticoNotas.ObtenerMaxima(notasArreglo);
            float notaMin = EstadisticoNotas.ObtenerMinima(notasArreglo);
            int aprobadosUNAH = EstadisticoNotas.ContarAprobados(notasArreglo);
            int reprobadosUNAH = cantidadNotas - aprobadosUNAH;
            double desviacionS = EstadisticoNotas.CalcularDesviacion(notasArreglo, promFinal);

            // Mostrar resultados con concatenación (+)
            Console.WriteLine("\n--- RESULTADOS ESTADÍSTICOS ---");
            Console.WriteLine("Promedio General: " + promFinal);
            Console.WriteLine("Nota más alta: " + notaMax);
            Console.WriteLine("Nota más baja: " + notaMin);
            Console.WriteLine("Cantidad de aprobados (65%): " + aprobadosUNAH);
            Console.WriteLine("Cantidad de reprobados: " + reprobadosUNAH);
            Console.WriteLine("Desviación Estándar: " + desviacionS);
        break;
//---------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------
        case 24:
            Console.WriteLine("--- GESTIÓN DE VECTORES DE 10 ELEMENTOS ---");

            int[] vecDiez = new int[10];

            // Llenado del arreglo
            for (int iV = 0; iV < 10; iV++)
            {
                vecDiez[iV] = (int)LeerFloat("Ingrese el numero para la posicion " + iV + ": ");
            }

            // 1. Encontrar el segundo mayor
            int segMayor = LogicaVectores.ObtenerSegundoMayor(vecDiez);
            Console.WriteLine("\nEl segundo valor mas grande es: " + segMayor);

            // 2. Mostrar posiciones pares
            Console.WriteLine("Elementos en indices pares: " + LogicaVectores.ObtenerPosicionesPares(vecDiez));

            // 3. Búsqueda Lineal
            int valorABuscarVec = (int)LeerFloat("\nIngrese un valor para buscar su posicion: ");
            int posEncontrada = LogicaVectores.BusquedaLineal(vecDiez, valorABuscarVec);

            if (posEncontrada != -1)
                Console.WriteLine("Valor encontrado en el indice: " + posEncontrada);
            else
                Console.WriteLine("El valor no existe en el arreglo.");

            // 4. Ordenamiento y mostrado final
            LogicaVectores.OrdenarBurbuja(vecDiez);
            Console.WriteLine("\nArreglo ordenado ascendentemente:");
            for (int k = 0; k < vecDiez.Length; k++)
            {
                Console.Write(vecDiez[k] + " ");
            }
            Console.WriteLine();

        break;
//---------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------
        case 25:

            int tamRot = (int)LeerFloat("Ingrese el tamaño del arreglo (N): ");
            int[] datosRot = new int[tamRot];

            for (int iR = 0; iR < tamRot; iR++)
            {
                datosRot[iR] = (int)LeerFloat("Valor posicion " + iR + ": ");
            }

            int opcRot;
            do
            {
                Console.WriteLine("\nArreglo actual: " + ManejadorRotacion.MostrarArreglo(datosRot));
                Console.WriteLine("1. Rotar K posiciones a la izquierda");
                Console.WriteLine("2. Rotar K posiciones a la derecha");
                Console.WriteLine("3. Invertir arreglo");
                Console.WriteLine("4. Salir");
                opcRot = (int)LeerFloat("Seleccione una opcion: ");

                if (opcRot == 1 || opcRot == 2)
                {
                    int kPos = (int)LeerFloat("¿Cuantas posiciones desea rotar?: ");
                    if (opcRot == 1)
                        datosRot = ManejadorRotacion.RotarIzquierda(datosRot, kPos);
                    else
                        datosRot = ManejadorRotacion.RotarDerecha(datosRot, kPos);
                }
                else if (opcRot == 3)
                {
                    datosRot = ManejadorRotacion.InvertirArreglo(datosRot);
                }

            } while (opcRot != 4);
        break;
//---------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------
        case 26:
            Console.WriteLine("--- ANALIZADOR DE FRECUENCIAS (20 números aleatorios) ---");

            Random genAzar = new Random();
            int[] listaNumeros = new int[20];
            string visualizacion = "";

            // Generar y mostrar los números
            for (int iF = 0; iF < 20; iF++)
            {
                listaNumeros[iF] = genAzar.Next(1, 11); // Entre 1 y 10
                visualizacion = visualizacion + listaNumeros[iF] + " ";
            }

            Console.WriteLine("\nNumeros generados: " + visualizacion);

            // Procesar frecuencias
            int[] tablaFrecuencias = AnalizadorFrecuencia.CalcularFrecuencias(listaNumeros);
            int masRepetido = AnalizadorFrecuencia.ObtenerMasFrecuente(tablaFrecuencias);
            int menosRepetido = AnalizadorFrecuencia.ObtenerMenosFrecuente(tablaFrecuencias);

            Console.WriteLine("\n--- REPORTE DE FRECUENCIAS ---");
            for (int j = 1; j <= 10; j++)
            {
                if (tablaFrecuencias[j] > 0)
                {
                    Console.WriteLine("Numero " + j + ": " + tablaFrecuencias[j] + " veces.");
                }
            }

            Console.WriteLine("\nEl numero que MAS aparecio: " + masRepetido + " (" + tablaFrecuencias[masRepetido] + " veces)");
            Console.WriteLine("El numero que MENOS aparecio: " + menosRepetido + " (" + tablaFrecuencias[menosRepetido] + " veces)");
        break;
//---------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------
        case 27:
            Console.WriteLine("--- REGISTRO DE TEMPERATURAS SEMANALES ---");

            float[] semanaTemps = new float[7];
            string[] diasNombre = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

            // Captura de datos
            for (int iTemp = 0; iTemp < 7; iTemp++)
            {
                semanaTemps[iTemp] = LeerFloat("Ingrese la temperatura del " + diasNombre[iTemp] + ": ");
            }

            // Procesamiento
            float promedioSemanal = AnalizadorClima.CalcularPromedio(semanaTemps);
            float tempMax = AnalizadorClima.ObtenerMaxima(semanaTemps);
            float tempMin = AnalizadorClima.ObtenerMinima(semanaTemps);
            string sobreProm = AnalizadorClima.DiasSobrePromedio(semanaTemps, promedioSemanal);
            string variacionDiaria = AnalizadorClima.CalcularVariaciones(semanaTemps);

            // Reporte con concatenación (+)
            Console.WriteLine("\n--- REPORTE CLIMATOLÓGICO ---");
            Console.WriteLine("Promedio de la semana: " + promedioSemanal + "°");
            Console.WriteLine("Temperatura mas alta: " + tempMax + "°");
            Console.WriteLine("Temperatura mas baja: " + tempMin + "°");
            Console.WriteLine("Dias sobre el promedio: " + (sobreProm == "" ? "Ninguno" : sobreProm));
            Console.WriteLine("\nVariaciones consecutivas:");
            Console.WriteLine(variacionDiaria);
        break;
//---------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------
        case 28:
            Console.WriteLine("--- REGISTRO ACADÉMICO POR PARCIALES ---");

            int cantEst = (int)LeerFloat("Ingrese la cantidad de estudiantes: ");
            float[,] matrizNotas = new float[cantEst, 3];

            // Llenado de la matriz
            for (int iE = 0; iE < cantEst; iE++)
            {
                Console.WriteLine("\nNotas del Estudiante #" + (iE + 1) + ":");
                for (int jP = 0; jP < 3; jP++)
                {
                    float notaP;
                    do {
                        notaP = LeerFloat("  Parcial " + (jP + 1) + ": ");
                        if (notaP < 0 || notaP > 100) Console.WriteLine("  Error: Nota invalida.");
                    } while (notaP < 0 || notaP > 100);
                    
                    matrizNotas[iE, jP] = notaP;
                }
            }

            // Reporte de Promedios por Estudiante
            Console.WriteLine("\n--- PROMEDIOS POR ESTUDIANTE ---");
            for (int i = 0; i < cantEst; i++)
            {
                float pEst = AnalizadorAcademia.CalcularPromedioEstudiante(matrizNotas, i);
                Console.WriteLine("Estudiante #" + (i + 1) + ": " + pEst + "%");
            }

            // Reporte de Parciales
            Console.WriteLine("\n--- ESTADÍSTICAS GLOBALES ---");
            for (int j = 0; j < 3; j++)
            {
                float pPar = AnalizadorAcademia.CalcularPromedioParcial(matrizNotas, j, cantEst);
                Console.WriteLine("Promedio Parcial " + (j + 1) + ": " + pPar + "%");
            }

            int elMejor = AnalizadorAcademia.ObtenerMejorEstudiante(matrizNotas, cantEst);
            int elDificil = AnalizadorAcademia.ObtenerParcialMasDificil(matrizNotas, cantEst);

            Console.WriteLine("\nEl mejor estudiante es el #" + (elMejor + 1));
            Console.WriteLine("El parcial mas dificil (promedio mas bajo) fue el #" + (elDificil + 1));
        break;
//---------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------
        case 29:
            bool jugarDeNuevo = true;

            while (jugarDeNuevo)
            {
                LogicaGato.InicializarTablero();
                int movimientosTotal = 0;
                bool hayGanador = false;
                char turnoActual = 'X';

                Console.WriteLine("--- JUEGO DEL GATO (TIC-TAC-TOE) ---");

                while (movimientosTotal < 9 && !hayGanador)
                {
                    Console.Clear();
                    Console.WriteLine("Turno del Jugador: " + turnoActual);
                    Console.WriteLine(LogicaGato.ObtenerTableroTexto());

                    int posElegida = (int)LeerFloat("Elija una posicion (1-9): ");

                    if (posElegida >= 1 && posElegida <= 9)
                    {
                        if (LogicaGato.RealizarMovimiento(posElegida, turnoActual))
                        {
                            movimientosTotal = movimientosTotal + 1;
                            if (LogicaGato.VerificarGanador())
                            {
                                hayGanador = true;
                            }
                            else
                            {
                                // Cambiar turno
                                turnoActual = (turnoActual == 'X') ? 'O' : 'X';
                            }
                        }
                        else
                        {
                            Console.WriteLine("¡Posicion ya ocupada! Presione una tecla...");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Posicion invalida. Presione una tecla...");
                        Console.ReadKey();
                    }
                }

                Console.Clear();
                Console.WriteLine(LogicaGato.ObtenerTableroTexto());

                if (hayGanador)
                    Console.WriteLine("¡FELICIDADES! El Jugador (" + turnoActual + ") ha ganado.");
                else
                    Console.WriteLine("¡EMPATE! Se han agotado los movimientos.");

                Console.WriteLine("\n¿Desea jugar de nuevo? (1: Si / 2: No)");
                int rc29 = (int)LeerFloat("Opcion: ");
                if (rc29 != 1) jugarDeNuevo = false;
            }

            Console.WriteLine("Gracias por jugar. ¡Adios!");
        break;
//---------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------
        case 30:
            Console.WriteLine("--- REGISTRO INICIAL DE 5 PRODUCTOS ---");
            for (int iP = 0; iP < 5; iP++)
            {
                Console.WriteLine("\nProducto #" + (iP + 1));
                float c = LeerFloat("Codigo: ");
                Console.Write("Nombre: ");
                string nc30 = Console.ReadLine() ?? "Sin nombre";
                float q = LeerFloat("Cantidad inicial: ");
                float p = LeerFloat("Precio: ");
                
                LogicaInventario.RegistrarProducto(iP, c, nc30, q, p);
            }

            int opcInv;
            do
            {
                Console.WriteLine("\n--- MENU DE INVENTARIO ---");
                Console.WriteLine("1. Mostrar Todo\n2. Buscar Producto\n3. Actualizar Cantidad\n4. Valor Total\n5. Salir");
                opcInv = (int)LeerFloat("Seleccione una opcion: ");

                switch (opcInv)
                {
                    case 1:
                        Console.WriteLine(LogicaInventario.ObtenerInventarioCompleto());
                        break;
                    case 2:
                        float codB = LeerFloat("Ingrese codigo a buscar: ");
                        int idxB = LogicaInventario.BuscarPorCodigo(codB);
                        if (idxB != -1)
                            Console.WriteLine("Encontrado: " + LogicaInventario.ObtenerNombre(idxB));
                        else
                            Console.WriteLine("Producto no registrado.");
                        break;
                    case 3:
                        float codA = LeerFloat("Codigo del producto a actualizar: ");
                        int idxA = LogicaInventario.BuscarPorCodigo(codA);
                        if (idxA != -1)
                        {
                            float nCant = LeerFloat("Nueva cantidad para " + LogicaInventario.ObtenerNombre(idxA) + ": ");
                            LogicaInventario.ActualizarExistencia(idxA, nCant);
                            Console.WriteLine("Inventario actualizado.");
                        }
                        else Console.WriteLine("No se encontro el codigo.");
                        break;
                    case 4:
                        Console.WriteLine("El valor total del inventario es: L. " + LogicaInventario.CalcularValorTotal());
                        break;
                }
            } while (opcInv != 5);
        break;

        default:
        Console.WriteLine("opcion invalida");
        break;
        }
        //terminacion del swicth

        salida = MenuSalida();
    } while (salida == 2);

} while (opcion != 0);

    


// Funciones internas que me ayudan acortar el codigo

static void MostrarMenu()
{
    Console.WriteLine("--------------Menu---------------");
    Console.WriteLine("-------------Bloque 1------------");
    Console.WriteLine("1. Calculadora de IMC");
    Console.WriteLine("2. Conversion de temperatura");
    Console.WriteLine("3. Desglose de billetes");
    Console.WriteLine("4. Calculadora de prestamo simple");
    Console.WriteLine("5. Tiempo transcurrido");
    Console.WriteLine("6. Area y perimetro");
    Console.WriteLine("7. Conversion de unidades de almacenamiento");
    Console.WriteLine("8. Calculo de salrio semanal");
    Console.WriteLine("-------------Bloque 2------------");
    Console.WriteLine("9. Clasificación de triángulos");
    Console.WriteLine("10. Sistema de calificaciones de la UNAH");
    Console.WriteLine("11. Calculadora de descuentos");
    Console.WriteLine("12. Año bisisesto y días del mes");
    Console.WriteLine("13. Validador de fechas");
    Console.WriteLine("14. Cajero Automático");
    Console.WriteLine("-------------Bloque 3------------");
    Console.WriteLine("15. Tabla de multiplicar extendida");
    Console.WriteLine("16. Números primos en rango");
    Console.WriteLine("17. Serie Fibonacci");
    Console.WriteLine("18. Factorial y combinaciones");
    Console.WriteLine("19. Juego de adivinanza");
    Console.WriteLine("20. Validacion de Contraseña");
    Console.WriteLine("21. Patrón de asteriscos");
    Console.WriteLine("22. Calculadora del menú");
    Console.WriteLine("--------------Bloque 4-----------");
    Console.WriteLine("23. Estadisticas de calificaciones");
    Console.WriteLine("24. Búsqueda y ordenamiento");
    Console.WriteLine("25. Rotación de arreglo");
    Console.WriteLine("26. Frecuencia de elementos");
    Console.WriteLine("27. Arreglo de Tempperaturas");
    Console.WriteLine("--------------Bloque 5----------");
    Console.WriteLine("28. Matriz de notas por parcial");
    Console.WriteLine("29. Juego de Gato (Tic-tac-toe)");
    Console.WriteLine("30. Inventario simple");
    Console.WriteLine("0. salir");

}


static int MenuSalida()
{
    int op;

    do
    {
        Console.WriteLine("\n1. Volver al menú principal");
        Console.WriteLine("2. repetir el ejercicio");
        Console.WriteLine("0. Salir");
        Console.Write("Seleccione una opción: ");
     }
    while (!int.TryParse(Console.ReadLine(), out op) || (op != 0 && op != 1 && op != 2));

    if (op == 0)
    {
        Console.WriteLine("Saliendo del programa...");
        Environment.Exit(0);
    }

    Console.Clear();
    return op;
    }

static float LeerFloatPositivo(string mensaje)
{
    float valor;
    bool valido;

    do
    {
        Console.Write(mensaje);
        valido = float.TryParse(Console.ReadLine(), out valor);

    if (!valido || valor <= 0)
    {
        Console.WriteLine("Debe ingresar un valor válido mayor que 0.");
    }

    } while (!valido || valor <= 0);

    return valor;
}

static float LeerFloat(string mensaje)
{
    float valor;
    bool valido;

    do
    {
        Console.Write(mensaje);
        valido = float.TryParse(Console.ReadLine(), out valor);

        if (!valido)
        {
            Console.WriteLine("Debe ingresar un número válido.");
        }

    } while (!valido);

    return valor;
}

static int LeerEntero(string mensaje)
{
    int valor = 0;
    bool valido = false;

    do
    {
        Console.Write(mensaje);
        valido = int.TryParse(Console.ReadLine(), out valor);

        if (!valido || valor < 0)
        {
            Console.WriteLine("Por favor, ingrese un numero entero positivo.");
            valido = false;
        }
    } while (!valido);
    return valor;
}
    
   