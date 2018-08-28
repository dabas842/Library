﻿using LibraryData.Models;
using System.Collections.Generic;

namespace LibraryData
{
    public interface ICheckout
    {
        IEnumerable<Checkout> GetAll();

        Checkout GetById(int id);

        void Add(Checkout newCheckout);

        IEnumerable<CheckoutHistory> GetCheckoutHistory(int id);

        void PlaceHold(int assetId, int libraryCardId);

        void CheckoutItem(int id, int libraryCardId);

        void CheckInItem(int id);

        Checkout GetLatestCheckout(int id);

        int GetNumberOfCopies(int id);

        bool IsCheckedOut(int id);

        string GetCurrentHoldPatron(int id);

        string GetCurrentHoldPlaced(int id);

        string GetCurrentPatron(int id);

        IEnumerable<Hold> GetCurrentHolds(int id);

        void MarkLost(int id);

        void MarkFound(int id);
    }
}