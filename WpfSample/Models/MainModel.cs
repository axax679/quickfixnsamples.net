﻿using Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfSample.Models
{
    public class MainModel : BindableBaseModel
    {
        public NewOrderModel NewOrderModel { get; } = new NewOrderModel();

        public ObservableCollection<SymbolModel> Symbols { get; } = new ObservableCollection<SymbolModel>();

        public ObservableCollection<Position> Positions { get; } = new ObservableCollection<Position>();

        public ObservableCollection<Order> Orders { get; } = new ObservableCollection<Order>();

        public ObservableCollection<LogModel> Logs { get; } = new ObservableCollection<LogModel>();
    }
}