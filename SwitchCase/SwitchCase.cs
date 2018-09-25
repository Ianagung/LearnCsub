using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    public static class SwitchCase

    {
        internal static string DoSwitchNormal(string inString)
        {
            string outStat = "";
            string inStat = inString;
            switch (inStat)
            {
                case "Created":
                    outStat = "nothing";
                    break;
                case "Data Capture Completed":
                    outStat = "insert";
                    break;
                case "Un-Issue":
                    outStat = "update";
                    break;
                case "Appeal":
                    outStat = "update";
                    break;
                case "Reject Appeal":
                    outStat = "update";
                    break;
                case "Approve":
                    outStat = "update";
                    break;
                case "Cancelled":
                    outStat = "update";
                    break;
                case "Failed QA":
                    outStat = "update";
                    break;
                case "Spoiled":
                    outStat = "update";
                    break;
                case "Passed QA":
                    outStat = "update";
                    break;
                case "Delivered":
                    outStat = "update";
                    break;
                case "Activate":
                    outStat = "update";
                    break;
                case "Suspend":
                    outStat = "update";
                    break;
                case "Revoked":
                    outStat = "update";
                    break;
                case "Replacement":
                    outStat = "update";
                    break;
                case "Renewal":
                    outStat = "update";
                    break;
                case "MissPrint":
                    outStat = "cardProcess";
                    break;
                case "Card Printed":
                    outStat = "cardProcess";
                    break;
                default:
                    outStat = "other";
                    break;
            }
            return outStat;
        }

        internal static string DoSwitchContains(string inString)
        {
            string outStat = "";
            string inStat = inString;
            switch (inStat)
            {
                case string s when s.Contains("Create"):
                    outStat = "nothing";
                    break;
                case string s when s.Contains("Data"):
                    outStat = "insert";
                    break;
                case string s when s.Contains("Un-Issue"):
                    outStat = "update";
                    break;
                case string s when s.Contains("Appeal"):
                    outStat = "update";
                    break;
                case string s when s.Contains("Reject"):
                    outStat = "update";
                    break;
                case string s when s.Contains("Approve"):
                    outStat = "update";
                    break;
                case string s when s.Contains("Cancel"):
                    outStat = "update";
                    break;
                case string s when s.Contains("Failed"):
                    outStat = "update";
                    break;
                case string s when s.Contains("Spoiled"):
                    outStat = "update";
                    break;
                case string s when s.Contains("Passed"):
                    outStat = "update";
                    break;
                case string s when s.Contains("Delivered"):
                    outStat = "update";
                    break;
                case string s when s.Contains("Activate"):
                    outStat = "update";
                    break;
                case string s when s.Contains("Suspend"):
                    outStat = "update";
                    break;
                case string s when s.Contains("Revoked"):
                    outStat = "update";
                    break;
                case string s when s.Contains("Replace"):
                    outStat = "update";
                    break;
                case string s when s.Contains("Renewal"):
                    outStat = "update";
                    break;
                case string s when s.Contains("Miss"):
                    outStat = "cardProcess";
                    break;
                case string s when s.Contains("rinted"):
                    outStat = "cardProcess";
                    break;
                default:
                    outStat = "other";
                    break;
            }
            return outStat;
        }

        internal static string DoSwitchIgnoreCase(String inString)
        {
            string outStat = "";
            string inStat = inString;
            switch (inStat.ToLower())
            {
                case "created":
                    outStat = "nothing";
                    break;
                case "data capture completed":
                    outStat = "insert";
                    break;
                case "un-issue":
                    outStat = "update";
                    break;
                case "appeal":
                    outStat = "update";
                    break;
                case "reject appeal":
                    outStat = "update";
                    break;
                case "approve":
                    outStat = "update";
                    break;
                case "cancelled":
                    outStat = "update";
                    break;
                case "failed qa":
                    outStat = "update";
                    break;
                case "spoiled":
                    outStat = "update";
                    break;
                case "passed qa":
                    outStat = "update";
                    break;
                case "delivered":
                    outStat = "update";
                    break;
                case "activate":
                    outStat = "update";
                    break;
                case "suspend":
                    outStat = "update";
                    break;
                case "revoked":
                    outStat = "update";
                    break;
                case "replacement":
                    outStat = "update";
                    break;
                case "renewal":
                    outStat = "update";
                    break;
                case "missprint":
                    outStat = "cardProcess";
                    break;
                case "miss print":
                    outStat = "cardProcess";
                    break;
                case "card printed":
                    outStat = "cardProcess";
                    break;
                default:
                    outStat = "other";
                    break;
            }
            return outStat;
        }

    }
}
