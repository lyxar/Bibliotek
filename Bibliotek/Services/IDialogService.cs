﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotek.Services
{
    public interface IDialogService
    {
        void ShowAddDialog();
        void CloseAddDialog();

        void ShowRemoveDialog();
        void ShowReturnDialog();

        void ShowBorrowedBooksDialog();

        void ShowBorrowBookDialog();
    }
}
