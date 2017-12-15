﻿using AalborgZooProjekt.Model;

namespace AalborgZooProjekt.Interfaces
{
    public interface IOrder
    {
        void AttachZookeeperToOrder(Zookeeper zookeeper); // Work in progress
        void AddOrderLine(OrderLine orderLine);
        void SaveComment(string comment);
        void RemoveZookeeperFromOrder();
        void RemoveOrderLine(OrderLine orderLine);
        bool CanOrderBeSend();
        void SendOrder(ShoppingList shoppingList);
        bool CanOrderBeChanged();
        void ChangeUnit(OrderLine orderLine, Unit unit);
        void ChangeAmount(OrderLine orderLine, int amount);

    }
}
