using AutoMapper;
using BingoPelc.Entities;
using BingoPelc.Models;

namespace BingoPelc.Mappers;

public class QuestionMapper: Profile
{
    public QuestionMapper()
    {
        CreateMap<DailyBingo, DailyBingoDto>()
            .ForMember(dbd => dbd.Id, opt => opt.MapFrom(db => db.Id.ToString()))
            .ForMember(dbd => dbd.Date, opt => opt.MapFrom(db => db.Date))
            .ForMember(dbd => dbd.DailyQuestions, opt => opt.MapFrom(db => db.DailyQuestions))
            .ForMember(dbd => dbd.Win, opt => opt.MapFrom(db => db.Win));

        CreateMap<DailyQuestion, DailyQuestionDto>()
            .ForMember(dqd => dqd.Id, opt => opt.MapFrom(db => db.Id.ToString()))
            .ForMember(dqd => dqd.Question, opt => opt.MapFrom(db => db.Question.Title))
            .ForMember(dqd => dqd.Checked, opt => opt.MapFrom(db => db.Checked))
            .ForMember(dqd => dqd.Index, opt => opt.MapFrom(db => db.Index));
    }
}