using Exam.Models;
namespace Exam.Services;
public class PhoneService
{
    private List<Phone> phones;
    public PhoneService()
    {
        phones = new List<Phone>();
    }
    public Phone AddPhone(Phone phone)
    {
        phone.Id = Guid.NewGuid();
        phones.Add(phone);
        return phone;
    }
    public Phone GetById(Guid id)
    {
        foreach (Phone phone in phones)
        {
            if (phone.Id == id)
            {
                return phone;

            }
        }
        return null;
    }
    public bool DeletePhone(Phone deletedPhone)
    {
        var phone = GetById(deletedPhone.Id);
        phones.Remove(phone);
        return true;
    }
    public bool UpdatePhone(Phone updatedPhone)
    {
        var phone = GetById(updatedPhone.Id);

        if (phone.Id == null)
        {
            var index = phones.IndexOf(phone);
            phones[index] = phone;
            return true;
        }
        return false;
    }
    public List<Phone> GetAllPhones()
    {
        return phones;
    }
}
