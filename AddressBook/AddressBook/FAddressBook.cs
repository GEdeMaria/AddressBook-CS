using GEM.AddressBook;

namespace AddressBook
{
    public partial class FAddressBook : Form
    {
        private GEM.AddressBook.AddressBook AddressBook;
        private bool ContactLoading = false;

        private void PopulateList(int index)
        {
            lbxContacts.Items.Clear();
            foreach (Contact c in AddressBook.Contacts)
            {
                if (c.Name.TitleString != string.Empty)
                    lbxContacts.Items.Add(c.Name.TitleString);
                else
                    lbxContacts.Items.Add("No Name Contact");
            }
            TrySetSelection(index);
        }

        private void TrySetSelection(int index)
        {
            try
            {
                lbxContacts.SelectedIndex = index;
            }
            catch { }
        }

        private bool TryLoadContacts()
        {
            if (!File.Exists("/Contacts.book"))
                return false;
            AddressBook.LoadContacts("/Contacts.book");
            return true;
        }

        private void SaveContacts()
        {
            AddressBook.SaveContacts("/Contacts.book");
        }

        private void DisableEntry()
        {
            grbContact.Enabled = false;
        }

        private void EnableEntry()
        {
            grbContact.Enabled = true;
        }

        public FAddressBook()
        {
            InitializeComponent();
            AddressBook = new GEM.AddressBook.AddressBook();
        }

        private void FAddressBook_Load(object sender, EventArgs e)
        {
            DisableEntry();
            if (TryLoadContacts())
                PopulateList(0);
        }

        private void lbxContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContactLoading = true;
            EnableEntry();
            int index = lbxContacts.SelectedIndex;
            grbContact.Text = AddressBook[index].Id.ToString();
            txtPrefix.Text = AddressBook[index].Name.Prefix;
            txtFirst.Text = AddressBook[index].Name.First;
            txtMiddle.Text = AddressBook[index].Name.Middle;
            txtLast.Text = AddressBook[index].Name.Last;
            txtSuffix.Text = AddressBook[index].Name.Suffix;
            txtNotes.Text = AddressBook[index].Name.Notes;

            txtLine1.Text = AddressBook[index].Address.Line1;
            txtLine2.Text = AddressBook[index].Address.Line2;
            txtCity.Text = AddressBook[index].Address.City;
            txtState.Text = AddressBook[index].Address.State;
            txtCountry.Text = AddressBook[index].Address.Country;
            txtZip.Text = AddressBook[index].Address.Zip;

            txtEmail.Text = AddressBook[index].Emails.Address;
            txtPhone.Text = AddressBook[index].Phones.Number;
            ckbEmailType.Checked = AddressBook[index].Emails.Type == GEM.AddressBook.EmailTypes.Personal;
            cbxPhoneType.SelectedIndex = (int)AddressBook[index].Phones.Type;
            ContactLoading = false;
        }

        private void btnCreateContact_Click(object sender, EventArgs e)
        {
            AddressBook.CreateContact();
            PopulateList(lbxContacts.SelectedIndex);
        }

        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            AddressBook.DeleteContact(AddressBook[lbxContacts.SelectedIndex]);
            PopulateList(lbxContacts.SelectedIndex);
        }

        private void FAddressBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveContacts();
        }

        private void txtPrefix_TextChanged(object sender, EventArgs e)
        {
            if (!ContactLoading)
            {
                AddressBook[lbxContacts.SelectedIndex].Name.Prefix = txtPrefix.Text;
            }
        }
        private void txtFirst_TextChanged(object sender, EventArgs e)
        {
            if (!ContactLoading)
            {
                AddressBook[lbxContacts.SelectedIndex].Name.First = txtFirst.Text;
                PopulateList(lbxContacts.SelectedIndex);
            }
        }
        private void txtMiddle_TextChanged(object sender, EventArgs e)
        {
            if (!ContactLoading)
            {
                AddressBook[lbxContacts.SelectedIndex].Name.Middle = txtMiddle.Text;
                PopulateList(lbxContacts.SelectedIndex);
            }
        }
        private void txtLast_TextChanged(object sender, EventArgs e)
        {
            if (!ContactLoading)
            {
                AddressBook[lbxContacts.SelectedIndex].Name.Last = txtLast.Text;
                PopulateList(lbxContacts.SelectedIndex);
            }
        }
        private void txtSuffix_TextChanged(object sender, EventArgs e)
        {
            if (!ContactLoading)
            {
                AddressBook[lbxContacts.SelectedIndex].Name.Suffix = txtSuffix.Text;
            }
        }
        private void txtNotes_TextChanged(object sender, EventArgs e)
        {
            if (!ContactLoading)
            {
                AddressBook[lbxContacts.SelectedIndex].Name.Notes = txtNotes.Text;
                PopulateList(lbxContacts.SelectedIndex);
            }
        }
        private void txtLine1_TextChanged(object sender, EventArgs e)
        {
            if (!ContactLoading)
            {
                AddressBook[lbxContacts.SelectedIndex].Address.Line1 = txtLine1.Text;
            }
        }
        private void txtLine2_TextChanged(object sender, EventArgs e)
        {
            if (!ContactLoading)
            {
                AddressBook[lbxContacts.SelectedIndex].Address.Line2 = txtLine2.Text;
            }
        }
        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            if (!ContactLoading)
            {
                AddressBook[lbxContacts.SelectedIndex].Address.City = txtCity.Text;
            }
        }
        private void txtState_TextChanged(object sender, EventArgs e)
        {
            if (!ContactLoading)
            {
                AddressBook[lbxContacts.SelectedIndex].Address.State = txtState.Text;
            }
        }
        private void txtCountry_TextChanged(object sender, EventArgs e)
        {
            if (!ContactLoading)
            {
                AddressBook[lbxContacts.SelectedIndex].Address.Country = txtCountry.Text;
            }
        }
        private void txtZip_TextChanged(object sender, EventArgs e)
        {
            if (!ContactLoading)
            {
                AddressBook[lbxContacts.SelectedIndex].Address.Zip = txtZip.Text;
            }
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!ContactLoading)
            {
                AddressBook[lbxContacts.SelectedIndex].Emails.Address = txtEmail.Text;
            }
        }
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (!ContactLoading)
            {
                AddressBook[lbxContacts.SelectedIndex].Phones.Number = txtPhone.Text;
            }
        }
        private void ckbEmailType_CheckedChanged(object sender, EventArgs e)
        {
            if (!ContactLoading)
            {
                switch (AddressBook[lbxContacts.SelectedIndex].Emails.Type)
                {
                    case GEM.AddressBook.EmailTypes.Work:
                        AddressBook[lbxContacts.SelectedIndex].Emails.Type = GEM.AddressBook.EmailTypes.Personal;
                        break;
                    case GEM.AddressBook.EmailTypes.Personal:
                        AddressBook[lbxContacts.SelectedIndex].Emails.Type = GEM.AddressBook.EmailTypes.Work;
                        break;
                }
            }
        }
        private void cbxPhoneType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ContactLoading)
            {
                AddressBook[lbxContacts.SelectedIndex].Phones.Type = (GEM.AddressBook.PhoneTypes)cbxPhoneType.SelectedIndex;
            }
        }
    }
}