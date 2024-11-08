using AutoMapper;
using Core.Interfaces;
using Core.Models;
using Data.Entities;
using Data.Entities.VenichleInfo;

namespace Core.MapperProfiles
{
    public class AppProfile : Profile
    {
        public AppProfile()
        {
            CreateMap<Auction, AuctionShortModel>().ForMember(d => d.VenichleId, opt => opt.MapFrom(src => src.Venichle.Id))
                                                   .ForMember(d => d.CurrentPrice, opt => opt.MapFrom(src => src.StartPrice));

            CreateMap<AuctionCreateModel, Auction>().ForMember(dest => dest.Venichle, opt => opt.MapFrom(src => new Venichle
            {
                VIN = src.VIN,
                ManufactureDate = src.ManufactureDate,
                Odometr = src.Odometr,
                ExteriorColor = src.ExteriorColor,
                Problems = src.Problems,
                Description = src.Description,
                IsModified = src.IsModified,
                HaveProblems = src.HaveProblems,
                IsHTMLProblemList = src.IsHTMLProblemList,
                IsHTMLDescription = src.IsHTMLDescription,
                BrandId = src.BrandId,
                OwnerId = src.OwnerId,
                ModelId = src.ModelId,
                BodyStyleId = src.BodyStyleId,
                FuelTypeId = src.FuelTypeId,
                TransmissionId = src.TransmissionId
            })).AfterMap<AuctionCreating>();

            CreateMap<AuctionFullModel, Auction>().ForMember(dest => dest.Venichle, opt => opt.MapFrom(src => new Venichle
            {
                VIN = src.VIN,
                ManufactureDate = src.ManufactureDate,
                Odometr = src.Odometr,
                ExteriorColor = src.ExteriorColor,
                Problems = src.Problems,
                Description = src.Description,
                IsModified = src.IsModified,
                HaveProblems = src.HaveProblems,
                IsHTMLProblemList = src.IsHTMLProblemList,
                IsHTMLDescription = src.IsHTMLDescription,
                BrandId = src.BrandId,
                OwnerId = src.OwnerId,
                ModelId = src.ModelId,
                BodyStyleId = src.BodyStyleId,
                FuelTypeId = src.FuelTypeId,
                TransmissionId = src.TransmissionId,
                MainPhotoURL = src.MainPhoto,
                ExteriorPhotosURLId = src.ExteriorPhotos,
                InteriorPhotosURLId = src.InteriorPhotos
            }));

            CreateMap<Auction, AuctionFullModel>().ForMember(dest => dest.VIN, opt => opt.MapFrom(src => src.Venichle.VIN))
                                                  .ForMember(dest => dest.ManufactureDate, opt => opt.MapFrom(src => src.Venichle.ManufactureDate))
                                                  .ForMember(dest => dest.Odometr, opt => opt.MapFrom(src => src.Venichle.Odometr))
                                                  .ForMember(dest => dest.ExteriorColor, opt => opt.MapFrom(src => src.Venichle.ExteriorColor))
                                                  .ForMember(dest => dest.Problems, opt => opt.MapFrom(src => src.Venichle.Problems))
                                                  .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Venichle.Description))
                                                  .ForMember(dest => dest.IsModified, opt => opt.MapFrom(src => src.Venichle.IsModified))
                                                  .ForMember(dest => dest.HaveProblems, opt => opt.MapFrom(src => src.Venichle.HaveProblems))
                                                  .ForMember(dest => dest.IsHTMLProblemList, opt => opt.MapFrom(src => src.Venichle.IsHTMLProblemList))
                                                  .ForMember(dest => dest.IsHTMLDescription, opt => opt.MapFrom(src => src.Venichle.IsHTMLDescription))
                                                  .ForMember(dest => dest.MainPhoto, opt => opt.MapFrom(src => src.Venichle.MainPhotoURL))
                                                  .ForMember(dest => dest.ExteriorPhotos, opt => opt.MapFrom(src => src.Venichle.ExteriorPhotosURLId))
                                                  .ForMember(dest => dest.InteriorPhotos, opt => opt.MapFrom(src => src.Venichle.InteriorPhotosURLId))
                                                  .ForMember(dest => dest.BrandId, opt => opt.MapFrom(src => src.Venichle.BrandId))
                                                  .ForMember(dest => dest.OwnerId, opt => opt.MapFrom(src => src.Venichle.OwnerId))
                                                  .ForMember(dest => dest.ModelId, opt => opt.MapFrom(src => src.Venichle.ModelId))
                                                  .ForMember(dest => dest.BodyStyleId, opt => opt.MapFrom(src => src.Venichle.BodyStyleId))
                                                  .ForMember(dest => dest.FuelTypeId, opt => opt.MapFrom(src => src.Venichle.FuelTypeId))
                                                  .ForMember(dest => dest.TransmissionId, opt => opt.MapFrom(src => src.Venichle.TransmissionId));

            CreateMap<RegisterModel, User>().ForMember(dest => dest.PasswordHash, opt => opt.Ignore());
                                            
        }
    }

    public class AuctionCreating(IFileService service) : IMappingAction<AuctionCreateModel, Auction>
    {
        public void Process(AuctionCreateModel s, Auction d, ResolutionContext context)
        {
            d.Venichle.MainPhotoURL = service.SaveImage(s.MainPhoto).Result;
            d.Venichle.ExteriorPhotosURLId = service.SaveImages(s.ExteriorPhotos.ToList()).Result;
            d.Venichle.InteriorPhotosURLId = service.SaveImages(s.InteriorPhotos.ToList()).Result;
        }
    }


}
