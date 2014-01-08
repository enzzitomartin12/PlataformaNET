﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace WpfLab053
{
    /// <summary>
    /// Lógica de interacción para BindingADO.xaml
    /// </summary>
    public partial class BindingADO : Window
    {            
        
        //Define los objetos que contendran los datos de la BD (que serán los datos fuentes del binding)
        ProyectosDataSet miDataSet = new ProyectosDataSet();
        ProyectosDataSetTableAdapters.ClientesTableAdapter cliAdapter = new ProyectosDataSetTableAdapters.ClientesTableAdapter();
        ProyectosDataSetTableAdapters.ProyectosTableAdapter proAdapter = new ProyectosDataSetTableAdapters.ProyectosTableAdapter();
        
        public BindingADO()
        {
            
            InitializeComponent();
            //Llena los objetos con los datos desde la BD
            cliAdapter.Fill(miDataSet.Clientes);
            proAdapter.Fill(miDataSet.Proyectos);
            //Define el data contexto que será el origen para el binding de datos.
            grid1.DataContext = miDataSet.Clientes;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
