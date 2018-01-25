using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba1
{
    public partial class Form1 : Form
    {
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private Beet[] beet;
        private Cabbage[] cabbage;
        private Carrot[] carrot;
        private FryingPan fryingPan;
        private Grater grater;
        private Knife knife;
        private Meat[] meat;
        private Oil oil;
        private Onion[] onion;
        private Pan pan;
        private Passivation passivation;
        private Potato[] potato;
        private Salt salt;
        private StewBeet stewBeet;
        private Stove stove;
        private WaterTap waterTap;
        public Form1()
        {
            InitializeComponent();
            fryingPan = new FryingPan();
            grater = new Grater();
            knife = new Knife();
            pan = new Pan();
            stove = new Stove();
            waterTap = new WaterTap();
            passivation = new Passivation();
            passivation.isReady = false;
            stewBeet = new StewBeet();
            stewBeet.isReady = false;
        }

        private void washPotato_Click_1(object sender, EventArgs e)
        {
            if (numericPotato.Value > 0)
            {
                if (!waterTap.State)
                {
                    MessageBox.Show("Кран закрыт!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                potato = new Potato[Convert.ToInt32(numericPotato.Value)];
                for (int i = 0; i < potato.Length; ++i)
                {
                    potato[i] = new Potato();
                }
                for (int i = 0; i < potato.Length; ++i)
                {
                    potato[i].Dirty = 0;
                }
                numericPotato.Enabled = false;
                waterTapClose.Checked = true;
                washPotato.Enabled = false;
                MessageBox.Show("Картошку помыли, можно чистить", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Картошки нет!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void waterTapOpen_CheckedChanged(object sender, EventArgs e)
        {
            if (waterTapOpen.Checked)
            {
                waterTap.State = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (waterTapClose.Checked)
            {
                waterTap.State = false;
            }
        }

        private void washCarrot_Click(object sender, EventArgs e)
        {
            if (numericCarrot.Value > 0)
            {
                if (!waterTap.State)
                {
                    MessageBox.Show("Кран закрыт!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                carrot = new Carrot[Convert.ToInt32(numericCarrot.Value)];
                for (int i = 0; i < carrot.Length; ++i)
                {
                    carrot[i] = new Carrot();
                }
                for (int i = 0; i < carrot.Length; ++i)
                {
                    carrot[i].Dirty = 0;
                }
                numericCarrot.Enabled = false;
                waterTapClose.Checked = true;
                washCarrot.Enabled = false;
                MessageBox.Show("Морковь помыли, можно чистить", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Моркови нет", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void washOnion_Click(object sender, EventArgs e)
        {
            if (numericOnion.Value > 0)
            {
                if (!waterTap.State)
                {
                    MessageBox.Show("Кран закрыт!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                onion = new Onion[Convert.ToInt32(numericOnion.Value)];
                for (int i = 0; i < onion.Length; ++i)
                {
                    onion[i] = new Onion();
                }
                for (int i = 0; i < onion.Length; ++i)
                {
                    onion[i].Dirty = 0;
                }
                numericOnion.Enabled = false;
                waterTapClose.Checked = true;
                washOnion.Enabled = false;
                MessageBox.Show("Лук помыли, можно чистить", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Лука нет", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void washBeet_Click(object sender, EventArgs e)
        {
            if (numericBeet.Value > 0)
            {
                if (!waterTap.State)
                {
                    MessageBox.Show("Кран закрыт!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                beet = new Beet[Convert.ToInt32(numericBeet.Value)];
                for (int i = 0; i < beet.Length; ++i)
                {
                    beet[i] = new Beet();
                }
                for (int i = 0; i < beet.Length; ++i)
                {
                    beet[i].Dirty = 0;
                }
                numericBeet.Enabled = false;
                waterTapClose.Checked = true;
                washBeet.Enabled = false;
                MessageBox.Show("Свеклу помыли, можно чистить", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Свеклы нет", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void washCabbage_Click(object sender, EventArgs e)
        {
            if (numericCabbage.Value > 0)
            {
                if (!waterTap.State)
                {
                    MessageBox.Show("Кран закрыт!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cabbage = new Cabbage[Convert.ToInt32(numericCabbage.Value)];
                for (int i = 0; i < cabbage.Length; ++i)
                {
                    cabbage[i] = new Cabbage();
                }
                for (int i = 0; i < cabbage.Length; ++i)
                {
                    cabbage[i].Dirty = 0;
                }
                numericCabbage.Enabled = false;
                waterTapClose.Checked = true;
                cutCabbage.Enabled = true;
                washCabbage.Enabled = false;
                MessageBox.Show("Капусту помыли, можно резать", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Капусты нет", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cleanCarrot_Click(object sender, EventArgs e)
        {
            if (carrot == null)
            {
                MessageBox.Show("Моркови нет", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (carrot.Length == 0)
            {
                MessageBox.Show("Моркови нет", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < carrot.Length; ++i)
            {
                if (carrot[i].Dirty > 0)
                {
                    MessageBox.Show("Морковь грязная!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            for (int i = 0; i < carrot.Length; ++i)
            {
                knife.Clean_carrot(carrot[i]);
            }
            cleanCarrot.Enabled = false;
            cutCarrot.Enabled = true;
            MessageBox.Show("Морковь почистили, можно натереть", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cleanOnion_Click(object sender, EventArgs e)
        {
            if (onion == null)
            {
                MessageBox.Show("Лука нет", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (onion.Length == 0)
            {
                MessageBox.Show("Лука нет", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < onion.Length; ++i)
            {
                if (onion[i].Dirty > 0)
                {
                    MessageBox.Show("Лук грязный!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            for (int i = 0; i < onion.Length; ++i)
            {
                knife.Clean_onion(onion[i]);
            }
            cleanOnion.Enabled = false;
            cutOnion.Enabled = true;
            MessageBox.Show("Лук почистили, можно нарезать", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cleanBeet_Click(object sender, EventArgs e)
        {
            if (beet == null)
            {
                MessageBox.Show("Свеклы нет", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (beet.Length == 0)
            {
                MessageBox.Show("Свеклы нет", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < beet.Length; ++i)
            {
                if (beet[i].Dirty > 0)
                {
                    MessageBox.Show("Свекла грязная!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            for (int i = 0; i < beet.Length; ++i)
            {
                knife.Clean_beet(beet[i]);
            }
            cleanBeet.Enabled = false;
            cutBeet.Enabled = true;
            MessageBox.Show("Свеклу почистили, можно нарезать", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cleanPotato_Click(object sender, EventArgs e)
        {
            if (potato == null)
            {
                MessageBox.Show("Картошки нет", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (potato.Length == 0)
            {
                MessageBox.Show("Картошки нет", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < potato.Length; ++i)
            {
                if (potato[i].Dirty > 0)
                {
                    MessageBox.Show("Картошка грязная!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            for (int i = 0; i < potato.Length; ++i)
            {
                knife.Clean_potato(potato[i]);
            }
            cleanPotato.Enabled = false;
            cutPotato.Enabled = true;
            MessageBox.Show("Картошку почистили, можно нарезать", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cutOnion_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < onion.Length; i++)
            {
                knife.Cut_onion(onion[i]);
            }
            cutOnion.Enabled = false;
            addOnion.Enabled = true;
            MessageBox.Show("Лук нарезали, можно добавлять", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cutBeet_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < beet.Length; i++)
            {
                knife.Cut_beet(beet[i]);
            }
            cutBeet.Enabled = false;
            addBeet.Enabled = true;
            MessageBox.Show("Свеклу нарезали, можно добавлять", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cutCabbage_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cabbage.Length; i++)
            {
                knife.Cut_cabbage(cabbage[i]);
            }
            cutCabbage.Enabled = false;
            addCabage.Enabled = true;
            MessageBox.Show("Капусту нарезали, можно добавлять", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cutPotato_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < potato.Length; i++)
            {
                knife.Cut_potato(potato[i]);
            }
            cutPotato.Enabled = false;
            addPotato.Enabled = true;
            MessageBox.Show("Картошку нарезали, можно добавлять", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cutCarrot_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < carrot.Length; i++)
            {
                grater.Grat_carrot(carrot[i]);
            }
            cutCarrot.Enabled = false;
            addCarrot.Enabled = true;
            MessageBox.Show("Морковь натерли, можно добавлять", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void stoveTurnOn_CheckedChanged(object sender, EventArgs e)
        {
            stove.State = stoveTurnOn.Checked;
        }

        private void standPan_Click(object sender, EventArgs e)
        {
            pan.Init(Convert.ToInt32(numericPotato.Value), Convert.ToInt32(numericCabbage.Value), Convert.ToInt32(numericMeat.Value));
            stove.Pan = pan;
            makePan.Enabled = true;
            standPan.Enabled = false;
            addMeat.Enabled = true;
            MessageBox.Show("Кастрюля на плите", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void standFryingPan_Click(object sender, EventArgs e)
        {
            fryingPan.Init(Convert.ToInt32(numericBeet.Value), Convert.ToInt32(numericCarrot.Value), Convert.ToInt32(numericOnion.Value));
            stove.FryingPan = fryingPan;
            makeFryingPan.Enabled = true;
            standFryingPan.Enabled = false;
            addWaterFryingPan.Enabled = true;
            MessageBox.Show("Сковорода на плите", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void makePan_Click(object sender, EventArgs e)
        {
            if (stove.State)
            {
                if (!pan.FirstReadyToGo)
                {
                    MessageBox.Show("Не все еще готово!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (stove.Pan.MeatIsReady() && !pan.SecondReadyToGo)
                {
                    MessageBox.Show("Не все еще готово!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                stove.CookPan();
                if (stove.Pan.MeatIsReady() && !stove.Pan.IsReady)
                {
                    MessageBox.Show("Мясо сварилось!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (stove.Pan.MeatIsReady() && stove.Pan.IsReady)
                {
                    MessageBox.Show("Почти готово!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Включите плиту!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void makeFryingPan_Click(object sender, EventArgs e)
        {
            if (stove.State)
            {
                if (!fryingPan.FirstReadyToGo)
                {
                    MessageBox.Show("Не все еще готово!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (passivation.isReady && !fryingPan.SecondReadyToGo)
                {
                    MessageBox.Show("Не все еще готово!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                stove.CookFryingPan();
                if (stove.FryingPan.PassivationIsReady && !stove.FryingPan.StewBeetIsReady)
                {
                    passivation.isReady = true;
                    MessageBox.Show("Пассировка готова", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    stewBeet.isReady = true;
                    MessageBox.Show("Свекла потушена", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    makeFryingPan.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Включи плиту!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addPanWater_Click(object sender, EventArgs e)
        {
            if (!waterTap.State)
            {
                MessageBox.Show("Кран закрыт!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < 3; ++i)
            {
                pan.AddWater(waterTap.GetWater());
            }
            standPan.Enabled = true;
            addSalt.Enabled = true;
            waterTapClose.Checked = true;
            addPanWater.Enabled = false;
            MessageBox.Show("Воду залили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void addMeat_Click(object sender, EventArgs e)
        {
            if (numericMeat.Value > 0)
            {
                meat = new Meat[Convert.ToInt32(numericMeat.Value)];
                for (int i = 0; i < meat.Length; i++)
                {
                    meat[i] = new Meat();
                }
                for (int i = 0; i < meat.Length; i++)
                {
                    pan.AddMeat(meat[i]);
                }
                MessageBox.Show("Мясо в кастрюле", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numericMeat.Enabled = false;
                addMeat.Enabled = false;
            }
            else
            {
                MessageBox.Show("Мяса нет!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addPotato_Click(object sender, EventArgs e)
        {
            if (!pan.MeatIsReady())
            {
                MessageBox.Show("Мясо ещё не сварилось!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                for (int i = 0; i < potato.Length; i++)
                {
                    pan.AddPotato(potato[i]);
                }
                addPotato.Enabled = false;
                MessageBox.Show("Картошка в кастрюле", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addCabage_Click(object sender, EventArgs e)
        {
            if (!pan.MeatIsReady())
            {
                MessageBox.Show("Мясо ещё не сварилось!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                for (int i = 0; i < cabbage.Length; i++)
                {
                    pan.AddCabbage(cabbage[i]);
                }
                addCabage.Enabled = false;
                MessageBox.Show("Капуста в кастрюле", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addPasivation_Click(object sender, EventArgs e)
        {
            if (passivation.isReady)
            {
                pan.Passivat.isReady = true;
                MessageBox.Show("Пассировка в кастрюле", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addPasivation.Enabled = false;
            }
            else
            {
                MessageBox.Show("Пассировка не готова!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addStewBeet_Click(object sender, EventArgs e)
        {
            if (stewBeet.isReady)
            {
                pan.SB.isReady = true;
                MessageBox.Show("Свекла в кастрюле", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addStewBeet.Enabled = false;
            }
            else
            {
                MessageBox.Show("Свекла еще не потушена!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addSalt_Click(object sender, EventArgs e)
        {
            if (numericSalt.Value > 0)
            {
                salt = new Salt();
                salt.Count = Convert.ToDouble(numericSalt.Value);
                pan.AddSalt(salt);
                addSalt.Enabled = false;
                numericSalt.Enabled = false;
                MessageBox.Show("Соль насыпали", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Соли нет!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void theEnd_Click(object sender, EventArgs e)
        {
            if (stove.Pan.IsReady && !addSalt.Enabled)
            {
                theEnd.Enabled = false;
                makePan.Enabled = false;
                MessageBox.Show("Борщ готов!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Не посолили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addOil_Click(object sender, EventArgs e)
        {
            if (numericOil.Value > 0)
            {
                oil = new Oil();
                oil.Count = Convert.ToDouble(numericOil.Value);
                fryingPan.AddOil(oil);
                standFryingPan.Enabled = true;
                addOil.Enabled = false;
                numericOil.Enabled = false;
                MessageBox.Show("Масло налили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Масла нет!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addOnion_Click(object sender, EventArgs e)
        {
            if (stove.FryingPan == null)
            {
                MessageBox.Show("Поставьте сковородку на плиту!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                for (int i = 0; i < onion.Length; i++)
                {
                    fryingPan.AddOnion(onion[i]);
                }
                addOnion.Enabled = false;
                MessageBox.Show("Лук на сковородке", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addCarrot_Click(object sender, EventArgs e)
        {
            if (stove.FryingPan == null)
            {
                MessageBox.Show("Поставьте сковородку на плиту!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                for (int i = 0; i < carrot.Length; i++)
                {
                    fryingPan.AddCarrot(carrot[i]);
                }
                addCarrot.Enabled = false;
                MessageBox.Show("Морковь на сковородке", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void getPassivation_Click(object sender, EventArgs e)
        {
            addPasivation.Enabled = true;
            getPassivation.Enabled = false;
        }

        private void addBeet_Click(object sender, EventArgs e)
        {
            if (stove.FryingPan == null)
            {
                MessageBox.Show("Поставьте сковородку на плиту!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                for (int i = 0; i < beet.Length; i++)
                {
                    fryingPan.AddBeet(beet[i]);
                }
                addBeet.Enabled = false;
                MessageBox.Show("Свекла на сковородке", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addWaterFryingPan_Click(object sender, EventArgs e)
        {
            if (stove.FryingPan == null)
            {
                MessageBox.Show("Поставьте сковородку на плиту!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!waterTap.State)
                {
                    MessageBox.Show("Кран закрыт!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                for (int i = 0; i < 1; ++i)
                {
                    fryingPan.AddWater(waterTap.GetWater());
                }
                waterTapClose.Checked = true;
                addWaterFryingPan.Enabled = false;
                MessageBox.Show("Воду залили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void getStewBeet_Click(object sender, EventArgs e)
        {
            addStewBeet.Enabled = true;
            getStewBeet.Enabled = false;
        }
    }
}
