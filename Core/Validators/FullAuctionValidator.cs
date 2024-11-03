using Core.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Validators
{
    public class FullAuctionValidator : AbstractValidator<AuctionCreateModel>
    {
        public FullAuctionValidator()
        {
            RuleFor(x => x.SellerId)
                .GreaterThan(0).WithMessage("SellerId must be greater than 0.");

            RuleFor(x => x.TimeEnd)
                .GreaterThan(x => x.TimeStart).WithMessage("TimeEnd must be less than TimeEnd.");

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(100).WithMessage("Name cannot exceed 100 characters.");

            RuleFor(x => x.MinDescription)
                .NotEmpty().WithMessage("MinDescription is required.")
                .MaximumLength(500).WithMessage("MinDescription cannot exceed 500 characters.");

            RuleFor(x => x.StartPrice)
                .GreaterThan(0).WithMessage("StartPrice must be greater than 0.");

            RuleFor(x => x.CityNow)
                .NotEmpty().WithMessage("CityNow is required.")
                .MaximumLength(100).WithMessage("CityNow cannot exceed 100 characters.");

            RuleFor(x => x.VIN)
                .NotEmpty().WithMessage("VIN is required.")
                .Length(17).WithMessage("VIN must be exactly 17 characters long."); 

            RuleFor(x => x.ManufactureDate)
                .InclusiveBetween(1886, DateTime.Now.Year).WithMessage("ManufactureDate must be between 1886 and the current year.");

            RuleFor(x => x.Odometr)
                .GreaterThanOrEqualTo(0).WithMessage("Odometr must be greater than or equal to 0.");

            RuleFor(x => x.ExteriorColor)
                .NotEmpty().WithMessage("ExteriorColor is required.")
                .MaximumLength(50).WithMessage("ExteriorColor cannot exceed 50 characters.");

            RuleFor(x => x.MainPhoto)
                .NotEmpty().WithMessage("MainPhoto is required.");

            RuleFor(x => x.ExteriorPhotos)
                .Must(x => x != null && x.Count >= 4).WithMessage("You must upload at least 4 exterior photos.");

            RuleFor(x => x.InteriorPhotos)
                .Must(x => x != null && x.Count >= 4).WithMessage("You must upload at least 4 interior photos.");

            RuleFor(x => x.BrandId)
                .GreaterThan(0).WithMessage("BrandId must be greater than 0.");

            RuleFor(x => x.OwnerId)
                .GreaterThan(0).WithMessage("OwnerId must be greater than 0.");

            RuleFor(x => x.ModelId)
                .GreaterThan(0).WithMessage("ModelId must be greater than 0.");

            RuleFor(x => x.BodyStyleId)
                .GreaterThan(0).WithMessage("BodyStyleId must be greater than 0.");

            RuleFor(x => x.FuelTypeId)
                .GreaterThan(0).WithMessage("FuelTypeId must be greater than 0.");

            RuleFor(x => x.TransmissionId)
                .GreaterThan(0).WithMessage("TransmissionId must be greater than 0.");

        }

    }
}
