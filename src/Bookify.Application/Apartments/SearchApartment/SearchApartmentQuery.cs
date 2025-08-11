using Bookify.Application.Abstractions.Messaging;

namespace Bookify.Application.Apartments.SearchApartment;

public sealed record SearchApartmentQuery(
    DateOnly StartDate,
    DateOnly EndDate) : IQuery<IReadOnlyList<ApartmentResponse>>;