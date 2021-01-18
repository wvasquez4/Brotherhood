﻿using Brotherhood.Domain.DTOs;
using Brotherhood.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brotherhood.Services
{
    public static class ChapterMappers
    {
        public static List<ChapterDTO> ToListChapterDTO(this List<Chapter> chapters)
        {
            List<ChapterDTO> chapterDTOs = new List<ChapterDTO>();
            foreach (var chapterDto in chapterDTOs)
            {
                foreach (var chapter in chapters)
                {
                    chapterDto.TitleChapter = chapter.TitleChapter;
                    chapterDto.Comic = chapter.Comic;
                    chapterDto.Pages = chapter.Pages;
                }
            }
            return chapterDTOs;
        }

        public static ChapterDTO ToChapter(this Chapter chapterDTO)
        {
            return new ChapterDTO()
            {
                Comic = chapterDTO.Comic,
                Pages = chapterDTO.Pages,
                TitleChapter = chapterDTO.TitleChapter
            };
        }

        public static Chapter ToChapter(this ChapterDTO chapterDTO)
        {
            return new Chapter()
            {
                Comic = chapterDTO.Comic,
                Pages = chapterDTO.Pages,
                TitleChapter = chapterDTO.TitleChapter
            };
        }

        public static Chapter ToPutChapter(this PutChapterDTO putchapterDTO)
        {
            return new Chapter()
            {
                Comic = putchapterDTO.Comic,
                Pages = putchapterDTO.Pages,
                TitleChapter = putchapterDTO.TitleChapter
            };
        }

        public static DeleteChapterDTO ToChapterDelete(this ChapterDTO deleteChapter)
        {
            return new DeleteChapterDTO()
            {
                Comic = deleteChapter.Comic,
                Pages = deleteChapter.Pages,
                TitleChapter = deleteChapter.TitleChapter
            };
        }

        public static Chapter ToDeleteChapter(this DeleteChapterDTO deleteChapter)
        {
            return new Chapter()
            {
                Comic = deleteChapter.Comic,
                Pages = deleteChapter.Pages,
                TitleChapter = deleteChapter.TitleChapter
            };
        }
    }
}