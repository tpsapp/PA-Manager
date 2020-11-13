using System;
using System.IO;
using System.Windows.Forms;

namespace PA_Manager
{
    public partial class frmEdit : Form
    {
        private String sName;
        private String sFile;
        private String[] sLines;
        private String[] sHeader;
        private String[] sCells;
        private String[] sObjects;
        private String[] sRooms;
        private String[] sWorkQ;
        private String[] sRegime;
        private String[] sSupplyChain;
        private String[] sFinance;
        private String[] sPatrols;
        private String[] sElectricity;
        private String[] sWater;
        private String[] sResearch;
        private String[] sConstruction;
        private String[] sPenalties;
        private String[] sSectors;
        private String[] sGrants;
        private String[] sMisconduct;
        private String[] sVisitation;
        private String[] sThermometer;
        private String[] sSquads;
        private String[] sContraband;
        private String[] sVisibility;
        private int iCellsStart = 0;
        private int iObjectsStart = 0;
        private int iRoomsStart = 0;
        private int iWorkQStart = 0;
        private int iRegimeStart = 0;
        private int iSChainStart = 0;
        private int iFinanceStart = 0;
        private int iPatrolsStart = 0;
        private int iElectricityStart = 0;
        private int iWaterStart = 0;
        private int iResearchStart = 0;
        private int iConstructionStart = 0;
        private int iPenaltiesStart = 0;
        private int iSectorsStart = 0;
        private int iGrantsStart = 0;
        private int iMisconductStart = 0;
        private int iVisitationStart = 0;
        private int iThermometerStart = 0;
        private int iSquadsStart = 0;
        private int iContrabandStart = 0;
        private int iVisibilityStart = 0;
        private String sBalance;

        private String[] FillArray(int iStart, int iEnd)
        {
            String[] sTemp = new String[iEnd - iStart];
            int iTemp = 0;
            for (int i = iStart; i < iEnd; i++)
            {
                sTemp[iTemp] = sLines[i];
                iTemp++;
            }
            return sTemp;
        }

        private void LoadFile()
        {
            try
            {
                //load save game
                sLines = File.ReadAllLines(sFile);

                //get start lines for each area
                for (int i = 0; i < sLines.Length; i++)
                {
                    if (sLines[i].Contains("BEGIN Cells") && iCellsStart == 0)
                    {
                        iCellsStart = i;
                    }
                    if (sLines[i].Contains("BEGIN Objects") && (iObjectsStart == 0 || iObjectsStart < iCellsStart))
                    {
                        iObjectsStart = i;
                    }
                    if (sLines[i].Contains("BEGIN Rooms") && (iRoomsStart == 0 || iRoomsStart < iObjectsStart))
                    {
                        iRoomsStart = i;
                    }
                    if (sLines[i].Contains("BEGIN WorkQ") && (iWorkQStart == 0 || iWorkQStart < iRoomsStart))
                    {
                        iWorkQStart = i;
                    }
                    if (sLines[i].Contains("BEGIN Regime") && (iRegimeStart == 0 || iRegimeStart < iWorkQStart))
                    {
                        iRegimeStart = i;
                    }
                    if (sLines[i].Contains("BEGIN SupplyChain") && (iSChainStart == 0 || iSChainStart < iRegimeStart))
                    {
                        iSChainStart = i;
                    }
                    if (sLines[i].Contains("BEGIN Finance") && (iFinanceStart == 0 || iFinanceStart < iSChainStart))
                    {
                        iFinanceStart = i;
                    }
                    if (sLines[i].Contains("BEGIN Patrols") && (iPatrolsStart == 0 || iPatrolsStart < iFinanceStart))
                    {
                        iPatrolsStart = i;
                    }
                    if (sLines[i].Contains("BEGIN Electricity") && (iElectricityStart == 0 || iElectricityStart < iPatrolsStart))
                    {
                        iElectricityStart = i;
                    }
                    if (sLines[i].Contains("BEGIN Water") && (iWaterStart == 0 || iWaterStart < iElectricityStart))
                    {
                        iWaterStart = i;
                    }
                    if (sLines[i].Contains("BEGIN Research") && (iResearchStart == 0 || iResearchStart < iWaterStart))
                    {
                        iResearchStart = i;
                    }
                    if (sLines[i].Contains("BEGIN Construction") && (iConstructionStart == 0 || iConstructionStart < iResearchStart))
                    {
                        iConstructionStart = i;
                    }
                    if (sLines[i].Contains("BEGIN Penalties") && (iPenaltiesStart == 0 || iPenaltiesStart < iConstructionStart))
                    {
                        iPenaltiesStart = i;
                    }
                    if (sLines[i].Contains("BEGIN Sectors") && (iSectorsStart == 0 || iSectorsStart < iPenaltiesStart))
                    {
                        iSectorsStart = i;
                    }
                    if (sLines[i].Contains("BEGIN Grants") && (iGrantsStart == 0 || iGrantsStart < iSectorsStart))
                    {
                        iGrantsStart = i;
                    }
                    if (sLines[i].Contains("BEGIN Misconduct") && (iMisconductStart == 0 || iMisconductStart < iGrantsStart))
                    {
                        iMisconductStart = i;
                    }
                    if (sLines[i].Contains("BEGIN Visitation") && (iVisitationStart == 0 || iVisitationStart < iMisconductStart))
                    {
                        iVisitationStart = i;
                    }
                    if (sLines[i].Contains("BEGIN Thermometer") && (iThermometerStart == 0 || iThermometerStart < iVisitationStart))
                    {
                        iThermometerStart = i;
                    }
                    if (sLines[i].Contains("BEGIN Squads") && (iSquadsStart == 0 || iSquadsStart < iThermometerStart))
                    {
                        iSquadsStart = i;
                    }
                    if (sLines[i].Contains("BEGIN Contraband") && (iContrabandStart == 0 || iContrabandStart < iSquadsStart))
                    {
                        iContrabandStart = i;
                    }
                    if (sLines[i].Contains("BEGIN Visibility") && (iVisibilityStart == 0 || iVisibilityStart < iContrabandStart))
                    {
                        iVisibilityStart = i;
                    }
                }

                //Assign each array
                sHeader = FillArray(0, iCellsStart);
                sCells = FillArray(iCellsStart, iObjectsStart);
                sObjects = FillArray(iObjectsStart, iRoomsStart);
                sRooms = FillArray(iRoomsStart, iWorkQStart);
                sWorkQ = FillArray(iWorkQStart, iRegimeStart);
                sRegime = FillArray(iRegimeStart, iSChainStart);
                sSupplyChain = FillArray(iSChainStart, iFinanceStart);
                sFinance = FillArray(iFinanceStart, iPatrolsStart);
                sPatrols = FillArray(iPatrolsStart, iElectricityStart);
                sElectricity = FillArray(iElectricityStart, iWaterStart);
                sWater = FillArray(iWaterStart, iResearchStart);
                sResearch = FillArray(iResearchStart, iConstructionStart);
                sConstruction = FillArray(iConstructionStart, iPenaltiesStart);
                sPenalties = FillArray(iPenaltiesStart, iSectorsStart);
                sSectors = FillArray(iSectorsStart, iGrantsStart);
                sGrants = FillArray(iGrantsStart, iMisconductStart);
                sMisconduct = FillArray(iMisconductStart, iVisitationStart);
                sVisitation = FillArray(iVisitationStart, iThermometerStart);
                sThermometer = FillArray(iThermometerStart, iSquadsStart);
                sSquads = FillArray(iSquadsStart, iContrabandStart);
                sContraband = FillArray(iContrabandStart, iVisibilityStart);
                sVisibility = FillArray(iVisibilityStart, sLines.Length);

                //load header information
                tbVersion.Text = sHeader[1].Remove(0, 21).Trim();
                tbWidth.Text = sHeader[2].Remove(0, 21).Trim();
                tbHeight.Text = sHeader[3].Remove(0, 21).Trim();
                tbOriginW.Text = sHeader[4].Remove(0, 21).Trim();
                tbOriginH.Text = sHeader[5].Remove(0, 21).Trim();
                tbTime.Text = sHeader[6].Remove(0, 21).Trim();
                tbRandomSeed.Text = sHeader[7].Remove(0, 21).Trim();
                tbOIDNext.Text = sHeader[8].Remove(0, 21).Trim();
                if (sHeader[9].Remove(0, 21).Trim() == "true")
                {
                    cbElectric.Checked = true;
                }
                if (sHeader[10].Remove(0, 21).Trim() == "true")
                {
                    cbWater.Checked = true;
                }
                if (sHeader[11].Remove(0, 21).Trim() == "true")
                {
                    cbFood.Checked = true;
                }
                if (sHeader[12].Remove(0, 21).Trim() == "true")
                {
                    cbMisconduct.Checked = true;
                }
                if (sHeader[13].Remove(0, 21).Trim() == "true")
                {
                    cbDecay.Checked = true;
                }
                if (sHeader[14].Remove(0, 21).Trim() == "true")
                {
                    cbVisibility.Checked = true;
                }
                if (sHeader[15].Remove(0, 21).Trim() == "true")
                {
                    cbOCAligned.Checked = true;
                }
                tbBioVersions.Text = sHeader[16].Remove(0, 21).Trim();
                tbIntakeNext.Text = sHeader[17].Remove(0, 21).Trim();
                tbIntakeNum.Text = sHeader[18].Remove(0, 21).Trim();
                if (sHeader.Length > 19 && sHeader[19].Remove(0, 21).Trim() == "true")
                {
                    cbIntakeNorm.Checked = true;
                }

                //load regime information
                for (int i = 4; i < sRegime.Length - 1; i++)
                {
                    String sTime = sRegime[i].Remove(0, 8);
                    sTime = sTime.Remove(sTime.IndexOf(']'));
                    switch (sTime)
                    {
                        case "0":
                            {
                                lbRegime.Items[0] = sRegime[i].Remove(0, 27);
                            }
                            break;
                        case "1":
                            {
                                lbRegime.Items[1] = sRegime[i].Remove(0, 27);
                            }
                            break;
                        case "2":
                            {
                                lbRegime.Items[2] = sRegime[i].Remove(0, 27);
                            }
                            break;
                        case "3":
                            {
                                lbRegime.Items[3] = sRegime[i].Remove(0, 27);
                            }
                            break;
                        case "4":
                            {
                                lbRegime.Items[4] = sRegime[i].Remove(0, 27);
                            }
                            break;
                        case "5":
                            {
                                lbRegime.Items[5] = sRegime[i].Remove(0, 27);
                            }
                            break;
                        case "6":
                            {
                                lbRegime.Items[6] = sRegime[i].Remove(0, 27);
                            }
                            break;
                        case "7":
                            {
                                lbRegime.Items[7] = sRegime[i].Remove(0, 27);
                            }
                            break;
                        case "8":
                            {
                                lbRegime.Items[8] = sRegime[i].Remove(0, 27);
                            }
                            break;
                        case "9":
                            {
                                lbRegime.Items[9] = sRegime[i].Remove(0, 27);
                            }
                            break;
                        case "10":
                            {
                                lbRegime.Items[10] = sRegime[i].Remove(0, 27);
                            }
                            break;
                        case "11":
                            {
                                lbRegime.Items[11] = sRegime[i].Remove(0, 27);
                            }
                            break;
                        case "12":
                            {
                                lbRegime.Items[12] = sRegime[i].Remove(0, 27);
                            }
                            break;
                        case "13":
                            {
                                lbRegime.Items[13] = sRegime[i].Remove(0, 27);
                            }
                            break;
                        case "14":
                            {
                                lbRegime.Items[14] = sRegime[i].Remove(0, 27);
                            }
                            break;
                        case "15":
                            {
                                lbRegime.Items[15] = sRegime[i].Remove(0, 27);
                            }
                            break;
                        case "16":
                            {
                                lbRegime.Items[16] = sRegime[i].Remove(0, 27);
                            }
                            break;
                        case "17":
                            {
                                lbRegime.Items[17] = sRegime[i].Remove(0, 27);
                            }
                            break;
                        case "18":
                            {
                                lbRegime.Items[18] = sRegime[i].Remove(0, 27);
                            }
                            break;
                        case "19":
                            {
                                lbRegime.Items[19] = sRegime[i].Remove(0, 27);
                            }
                            break;
                        case "20":
                            {
                                lbRegime.Items[20] = sRegime[i].Remove(0, 27);
                            }
                            break;
                        case "21":
                            {
                                lbRegime.Items[21] = sRegime[i].Remove(0, 27);
                            }
                            break;
                        case "22":
                            {
                                lbRegime.Items[22] = sRegime[i].Remove(0, 27);
                            }
                            break;
                        case "23":
                            {
                                lbRegime.Items[23] = sRegime[i].Remove(0, 27);
                            }
                            break;
                        default:
                            break;
                    }
                }

                //Load finance information
                tbBalance.Text = sFinance[0].Remove(0, 25);
                tbBalance.Text = tbBalance.Text.Remove(tbBalance.Text.IndexOf('.'));
                sBalance = tbBalance.Text;

                //Load research information
                if (sResearch[1].Contains("1."))
                {
                    cbRNone.Checked = true;
                }
                if (sResearch[2].Contains("1."))
                {
                    cbRWarden.Checked = true;
                }
                if (sResearch[3].Contains("1."))
                {
                    cbRMaintenance.Checked = true;
                }
                if (sResearch[4].Contains("1."))
                {
                    cbRSecurity.Checked = true;
                }
                if (sResearch[5].Contains("1."))
                {
                    cbRLegal.Checked = true;
                }
                if (sResearch[6].Contains("1."))
                {
                    cbRMentalHealth.Checked = true;
                }
                if (sResearch[7].Contains("1."))
                {
                    cbRFinance.Checked = true;
                }
                if (sResearch[8].Contains("1."))
                {
                    cbRRedPen1.Checked = true;
                }
                if (sResearch[9].Contains("1."))
                {
                    cbRRedPen2.Checked = true;
                }
                if (sResearch[10].Contains("1."))
                {
                    cbRRedPen3.Checked = true;
                }
                if (sResearch[11].Contains("1."))
                {
                    cbRRedPen4.Checked = true;
                }
                if (sResearch[12].Contains("1."))
                {
                    cbRRedPen5.Checked = true;
                }
                if (sResearch[13].Contains("1."))
                {
                    cbRCCTV.Checked = true;
                }
                if (sResearch[14].Contains("1."))
                {
                    cbRHealth.Checked = true;
                }
                if (sResearch[15].Contains("1."))
                {
                    cbRCleaning.Checked = true;
                }
                if (sResearch[16].Contains("1."))
                {
                    cbRGroundsKeep.Checked = true;
                }
                if (sResearch[17].Contains("1."))
                {
                    cbRClone.Checked = true;
                }
                if (sResearch[18].Contains("1."))
                {
                    cbRDeployment.Checked = true;
                }
                if (sResearch[19].Contains("1."))
                {
                    cbRPrisonLabour.Checked = true;
                }
                if (sResearch[20].Contains("1."))
                {
                    cbRLandExp.Checked = true;
                }
                if (sResearch[21].Contains("1."))
                {
                    cbRContraband.Checked = true;
                }

                //Load Grant information
                for (int i = 0; i < sGrants.Length; i++)
                {
                    if (sGrants[i].Contains("bootstraps") && sGrants[i].Contains("Completed"))
                    {
                        cbGrant1.Checked = true;
                    }
                    else if (sGrants[i].Contains("Administration") && sGrants[i].Contains("Completed"))
                    {
                        cbGrant2.Checked = true;
                    }
                    else if (sGrants[i].Contains("FirstCellBlock") && sGrants[i].Contains("Completed"))
                    {
                        cbGrant3.Checked = true;
                    }
                    else if (sGrants[i].Contains("Health") && sGrants[i].Contains("Completed"))
                    {
                        cbGrant4.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void SaveFile()
        {
            //Update Header info
            sHeader[1] = "Version              " + tbVersion.Text;
            sHeader[2] = "NumCellsX            " + tbWidth.Text;
            sHeader[3] = "NumCellsY            " + tbHeight.Text;
            sHeader[4] = "OriginW              " + tbOriginW.Text;
            sHeader[5] = "OriginH              " + tbOriginH.Text;
            sHeader[6] = "TimeIndex            " + tbTime.Text;
            sHeader[7] = "RandomSeed           " + tbRandomSeed.Text;
            sHeader[8] = "ObjectId.next        " + tbOIDNext.Text;
            sHeader[9] = "EnabledElectricity   " + cbElectric.Checked.ToString().ToLower();
            sHeader[10] = "EnabledWater         " + cbWater.Checked.ToString().ToLower();
            sHeader[11] = "EnabledFood          " + cbFood.Checked.ToString().ToLower();
            sHeader[12] = "EnabledMisconduct    " + cbMisconduct.Checked.ToString().ToLower();
            sHeader[13] = "EnabledDecay         " + cbDecay.Checked.ToString().ToLower();
            sHeader[14] = "EnabledVisibility    " + cbVisibility.Checked.ToString().ToLower();
            sHeader[15] = "ObjectsCentreAligned " + cbOCAligned.Checked.ToString().ToLower();
            sHeader[16] = "BioVersions          " + tbBioVersions.Text;
            sHeader[17] = "Intake.next          " + tbIntakeNext.Text;
            sHeader[18] = "Intake.numPrisoners  " + tbIntakeNum.Text;
            if (sHeader.Length > 19)
            {
                sHeader[19] = "Intake.reqNormal     " + cbIntakeNorm.Checked.ToString().ToLower();
            }

            //update Regime info

            //update finance info
            sFinance[0] = sFinance[0].Replace(sBalance, tbBalance.Text);

            //update research info
            String sTemp = sResearch[1].Remove(0, sResearch[1].IndexOf('.') - 1);
            sTemp = sTemp.Remove(8);
            if (cbRNone.Checked)
            {
                sResearch[1] = sResearch[1].Replace(sTemp, "1.00000");
            }
            else
            {
                sResearch[1] = sResearch[1].Replace(sTemp, "0.00000");
            }
            sTemp = sResearch[2].Remove(0, sResearch[2].IndexOf('.') - 1);
            sTemp = sTemp.Remove(8);
            if (cbRWarden.Checked)
            {
                sResearch[2] = sResearch[2].Replace(sTemp, "1.00000");
            }
            else
            {
                sResearch[2] = sResearch[2].Replace(sTemp, "0.00000");
            }
            sTemp = sResearch[3].Remove(0, sResearch[3].IndexOf('.') - 1);
            sTemp = sTemp.Remove(8);
            if (cbRMaintenance.Checked)
            {
                sResearch[3] = sResearch[3].Replace(sTemp, "1.00000");
            }
            else
            {
                sResearch[3] = sResearch[3].Replace(sTemp, "0.00000");
            }
            sTemp = sResearch[4].Remove(0, sResearch[4].IndexOf('.') - 1);
            sTemp = sTemp.Remove(8);
            if (cbRSecurity.Checked)
            {
                sResearch[4] = sResearch[4].Replace(sTemp, "1.00000");
            }
            else
            {
                sResearch[4] = sResearch[4].Replace(sTemp, "0.00000");
            }
            sTemp = sResearch[5].Remove(0, sResearch[5].IndexOf('.') - 1);
            sTemp = sTemp.Remove(8);
            if (cbRLegal.Checked)
            {
                sResearch[5] = sResearch[5].Replace(sTemp, "1.00000");
            }
            else
            {
                sResearch[5] = sResearch[5].Replace(sTemp, "0.00000");
            }
            sTemp = sResearch[6].Remove(0, sResearch[6].IndexOf('.') - 1);
            sTemp = sTemp.Remove(8);
            if (cbRMentalHealth.Checked)
            {
                sResearch[6] = sResearch[6].Replace(sTemp, "1.00000");
            }
            else
            {
                sResearch[6] = sResearch[6].Replace(sTemp, "0.00000");
            }
            sTemp = sResearch[7].Remove(0, sResearch[7].IndexOf('.') - 1);
            sTemp = sTemp.Remove(8);
            if (cbRFinance.Checked)
            {
                sResearch[7] = sResearch[7].Replace(sTemp, "1.00000");
            }
            else
            {
                sResearch[7] = sResearch[7].Replace(sTemp, "0.00000");
            }
            sTemp = sResearch[8].Remove(0, sResearch[8].IndexOf('.') - 1);
            sTemp = sTemp.Remove(8);
            if (cbRRedPen1.Checked)
            {
                sResearch[8] = sResearch[8].Replace(sTemp, "1.00000");
            }
            else
            {
                sResearch[8] = sResearch[8].Replace(sTemp, "0.00000");
            }
            sTemp = sResearch[9].Remove(0, sResearch[9].IndexOf('.') - 1);
            sTemp = sTemp.Remove(8);
            if (cbRRedPen2.Checked)
            {
                sResearch[9] = sResearch[9].Replace(sTemp, "1.00000");
            }
            else
            {
                sResearch[9] = sResearch[9].Replace(sTemp, "0.00000");
            }
            sTemp = sResearch[10].Remove(0, sResearch[10].IndexOf('.') - 1);
            sTemp = sTemp.Remove(8);
            if (cbRRedPen3.Checked)
            {
                sResearch[10] = sResearch[10].Replace(sTemp, "1.00000");
            }
            else
            {
                sResearch[10] = sResearch[10].Replace(sTemp, "0.00000");
            }
            sTemp = sResearch[11].Remove(0, sResearch[11].IndexOf('.') - 1);
            sTemp = sTemp.Remove(8);
            if (cbRRedPen4.Checked)
            {
                sResearch[11] = sResearch[11].Replace(sTemp, "1.00000");
            }
            else
            {
                sResearch[11] = sResearch[11].Replace(sTemp, "0.00000");
            }
            sTemp = sResearch[12].Remove(0, sResearch[12].IndexOf('.') - 1);
            sTemp = sTemp.Remove(8);
            if (cbRRedPen5.Checked)
            {
                sResearch[12] = sResearch[12].Replace(sTemp, "1.00000");
            }
            else
            {
                sResearch[12] = sResearch[12].Replace(sTemp, "0.00000");
            }
            sTemp = sResearch[13].Remove(0, sResearch[13].IndexOf('.') - 1);
            sTemp = sTemp.Remove(8);
            if (cbRCCTV.Checked)
            {
                sResearch[13] = sResearch[13].Replace(sTemp, "1.00000");
            }
            else
            {
                sResearch[13] = sResearch[13].Replace(sTemp, "0.00000");
            }
            sTemp = sResearch[14].Remove(0, sResearch[14].IndexOf('.') - 1);
            sTemp = sTemp.Remove(8);
            if (cbRHealth.Checked)
            {
                sResearch[14] = sResearch[14].Replace(sTemp, "1.00000");
            }
            else
            {
                sResearch[14] = sResearch[14].Replace(sTemp, "0.00000");
            }
            sTemp = sResearch[15].Remove(0, sResearch[15].IndexOf('.') - 1);
            sTemp = sTemp.Remove(8);
            if (cbRCleaning.Checked)
            {
                sResearch[15] = sResearch[15].Replace(sTemp, "1.00000");
            }
            else
            {
                sResearch[15] = sResearch[15].Replace(sTemp, "0.00000");
            }
            sTemp = sResearch[16].Remove(0, sResearch[16].IndexOf('.') - 1);
            sTemp = sTemp.Remove(8);
            if (cbRGroundsKeep.Checked)
            {
                sResearch[16] = sResearch[16].Replace(sTemp, "1.00000");
            }
            else
            {
                sResearch[16] = sResearch[16].Replace(sTemp, "0.00000");
            }
            sTemp = sResearch[17].Remove(0, sResearch[17].IndexOf('.') - 1);
            sTemp = sTemp.Remove(8);
            if (cbRClone.Checked)
            {
                sResearch[17] = sResearch[17].Replace(sTemp, "1.00000");
            }
            else
            {
                sResearch[17] = sResearch[17].Replace(sTemp, "0.00000");
            }
            sTemp = sResearch[18].Remove(0, sResearch[18].IndexOf('.') - 1);
            sTemp = sTemp.Remove(8);
            if (cbRDeployment.Checked)
            {
                sResearch[18] = sResearch[18].Replace(sTemp, "1.00000");
            }
            else
            {
                sResearch[18] = sResearch[18].Replace(sTemp, "0.00000");
            }
            sTemp = sResearch[19].Remove(0, sResearch[19].IndexOf('.') - 1);
            sTemp = sTemp.Remove(8);
            if (cbRPrisonLabour.Checked)
            {
                sResearch[19] = sResearch[19].Replace(sTemp, "1.00000");
            }
            else
            {
                sResearch[19] = sResearch[19].Replace(sTemp, "0.00000");
            }
            sTemp = sResearch[20].Remove(0, sResearch[20].IndexOf('.') - 1);
            sTemp = sTemp.Remove(8);
            if (cbRLandExp.Checked)
            {
                sResearch[20] = sResearch[20].Replace(sTemp, "1.00000");
            }
            else
            {
                sResearch[20] = sResearch[20].Replace(sTemp, "0.00000");
            }
            sTemp = sResearch[21].Remove(0, sResearch[21].IndexOf('.') - 1);
            sTemp = sTemp.Remove(8);
            if (cbRContraband.Checked)
            {
                sResearch[21] = sResearch[21].Replace(sTemp, "1.00000");
            }
            else
            {
                sResearch[21] = sResearch[21].Replace(sTemp, "0.00000");
            }


            //update Grant information
            for (int i = 0; i < sGrants.Length; i++)
            {
                if (sGrants[i].Contains("bootstraps") && cbGrant1.Checked)
                {
                    sGrants[i] = "    BEGIN Grant_bootstraps Status Completed  END";
                }
                else if (sGrants[i].Contains("Administration") && cbGrant2.Checked)
                {
                    sGrants[i] = "    BEGIN Grant_Administration Status Completed  END";
                }
                else if (sGrants[i].Contains("FirstCellBlock") && cbGrant3.Checked)
                {
                    sGrants[i] = "    BEGIN Grant_FirstCellBlock Status Completed  END";
                }
                else if (sGrants[i].Contains("Health") && cbGrant4.Checked)
                {
                    sGrants[i] = "    BEGIN Grant_Health Status Completed  END";
                }

                if (sGrants[i].Contains("bootstraps") && !cbGrant1.Checked)
                {
                    sGrants[i] = "    BEGIN Grant_bootstraps Status InProgress  END";
                }
                else if (sGrants[i].Contains("Administration") && !cbGrant2.Checked)
                {
                    sGrants[i] = "    BEGIN Grant_Administration Status InProgress  END";
                }
                else if (sGrants[i].Contains("FirstCellBlock") && !cbGrant3.Checked)
                {
                    sGrants[i] = "    BEGIN Grant_FirstCellBlock Status InProgress  END";
                }
                else if (sGrants[i].Contains("Health") && !cbGrant4.Checked)
                {
                    sGrants[i] = "    BEGIN Grant_Health Status InProgress  END";
                }
            }

            //Write saved game info
            File.WriteAllLines(sFile, sHeader);
            File.AppendAllLines(sFile, sCells);
            File.AppendAllLines(sFile, sObjects);
            File.AppendAllLines(sFile, sRooms);
            File.AppendAllLines(sFile, sWorkQ);
            File.AppendAllLines(sFile, sRegime);
            File.AppendAllLines(sFile, sSupplyChain);
            File.AppendAllLines(sFile, sFinance);
            File.AppendAllLines(sFile, sPatrols);
            File.AppendAllLines(sFile, sElectricity);
            File.AppendAllLines(sFile, sWater);
            File.AppendAllLines(sFile, sResearch);
            File.AppendAllLines(sFile, sConstruction);
            File.AppendAllLines(sFile, sPenalties);
            File.AppendAllLines(sFile, sSectors);
            File.AppendAllLines(sFile, sGrants);
            File.AppendAllLines(sFile, sMisconduct);
            File.AppendAllLines(sFile, sVisitation);
            File.AppendAllLines(sFile, sThermometer);
            File.AppendAllLines(sFile, sSquads);
            File.AppendAllLines(sFile, sContraband);
            File.AppendAllLines(sFile, sVisibility);
        }

        public frmEdit(String sGame, String sPath)
        {
            InitializeComponent();
            sName = sGame;
            sFile = sPath;
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
    }
}
