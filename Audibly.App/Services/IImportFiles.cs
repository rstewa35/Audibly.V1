﻿// Author: rstewa
// Created: 3/6/2024
// Updated: 3/6/2024

using System.Threading.Tasks;

namespace Audibly.App.Services;

public interface IImportFiles
{
    Task ImportAsync(string path);
}