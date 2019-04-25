namespace NetQuax.Entities
{
  internal interface IUser
  {
    Address GetAddressByUser(int userId);

    BillingInformation GetBillingInformationByUser(int UserId);
  }
}