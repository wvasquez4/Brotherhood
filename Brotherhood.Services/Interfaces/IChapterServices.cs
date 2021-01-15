﻿using Brotherhood.Domain.DTOs;
using Brotherhood.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brotherhood.Services.Interfaces
{
    public interface IChapterServices
    {
        Task<IEnumerable<ChapterDTO>> GetChaptersAsync();
        Task AddChaptersAsync(ChapterDTO entity);
        Task ModifyChaptersAsync(ChapterDTO entity);
        Task DeleteChaptersAsync(ChapterDTO entity);
    }
}