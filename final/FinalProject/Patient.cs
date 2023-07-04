using System;

abstract class Patient
{
    protected string _name;
    protected string _gender;
    protected string _birthdate;
    protected string _phone;
    protected string _billingAddress;
    protected string _profession;

    public Patient(string name, string sex, string bday, string phone, string address, string job)
    {
        _name = name;
        _gender = sex;
        _birthdate = bday;
        _billingAddress = address;
        _phone = phone;
        _profession = job;
    }

    public abstract void MakeNewEntry();
    public abstract string RetrievePatientDetails();
    
}