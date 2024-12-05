namespace HRMS.UI.Tools
{
    public static class FP
    {
        /// <summary>
        ///  Formun açık olup olmadığını kontrol ederek belirtilen fMdiParent formun içine fMdiChild açmasını sağlar
        /// </summary>
        public static void FormControlAndOpenInMdi(Form fMdiParent, Form fMdiChild)
        {
            bool isOpen = false;
            fMdiChild.MdiParent = fMdiParent;
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == fMdiChild.GetType())
                {
                    isOpen = true;
                }
            }
            if (isOpen)
            {
                MessageBox.Show("Bu Form zaten açık durumda.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                fMdiChild.Show();
            }
        }





    }
}
