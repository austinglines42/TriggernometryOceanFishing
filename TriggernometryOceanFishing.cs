using Triggernometry.Variables;

// Adds 2 hours per testHour to the current time to test other routes
int testHour = 0;

// Variable that tells Triggernometry who changed or created a variable
string changedBy = "Ocean Fish Helper";

// All code to calculate the current route is from Lulu's Tools
// You can read more about it here: https://ffxiv.pf-n.co/ocean-fishing/about
string[] PATTERN = {
    "BD", "TD", "ND", "RD", "BS", "TS", "NS", "RS", "BN", "TN", "NN", "RN",
    "TD", "ND", "RD", "BS", "TS", "NS", "RS", "BN", "TN", "NN", "RN", "BD",
    "ND", "RD", "BS", "TS", "NS", "RS", "BN", "TN", "NN", "RN", "BD", "TD",
    "RD", "BS", "TS", "NS", "RS", "BN", "TN", "NN", "RN", "BD", "TD", "ND",
    "BS", "TS", "NS", "RS", "BN", "TN", "NN", "RN", "BD", "TD", "ND", "RD",
    "TS", "NS", "RS", "BN", "TN", "NN", "RN", "BD", "TD", "ND", "RD", "BS",
    "NS", "RS", "BN", "TN", "NN", "RN", "BD", "TD", "ND", "RD", "BS", "TS",
    "RS", "BN", "TN", "NN", "RN", "BD", "TD", "ND", "RD", "BS", "TS", "NS",
    "BN", "TN", "NN", "RN", "BD", "TD", "ND", "RD", "BS", "TS", "NS", "RS",
    "TN", "NN", "RN", "BD", "TD", "ND", "RD", "BS", "TS", "NS", "RS", "BN",
    "NN", "RN", "BD", "TD", "ND", "RD", "BS", "TS", "NS", "RS", "BN", "TN",
    "RN", "BD", "TD", "ND", "RD", "BS", "TS", "NS", "RS", "BN", "TN", "NN"
};
long TWO_HOURS = 2 * 60 * 60 * 1000;
int OFFSET = 88;
long currTime = DateTimeOffset.Now.ToUnixTimeMilliseconds() + (TWO_HOURS * testHour);
long voyageNumber = currTime / TWO_HOURS;
string route = PATTERN[(OFFSET + voyageNumber) % PATTERN.Length];

// Initialize the VariableList to return to Triggernometry
VariableList objectivesVL = new VariableList();

// Switch statement that pushes objectives onto the objectivesVL VariableList based on the route.
switch (route)
{
    case "BD":
        objectivesVL.Push(new VariableScalar() { Value = "Crabs" }, changedBy);
        objectivesVL.Push(new VariableScalar() { Value = "Seafaring Toad" }, changedBy);
        break;
    case "TD":
        objectivesVL.Push(new VariableScalar() { Value = "Fugu" }, changedBy);
        objectivesVL.Push(new VariableScalar() { Value = "Mantas" }, changedBy);
        break;
    case "ND":
        objectivesVL.Push(new VariableScalar() { Value = "Sothis" }, changedBy);
        objectivesVL.Push(new VariableScalar() { Value = "Elasmosaurus" }, changedBy);
        break;
    case "RD":
        objectivesVL.Push(new VariableScalar() { Value = "Sharks" }, changedBy);
        objectivesVL.Push(new VariableScalar() { Value = "Coral Manta" }, changedBy);
        break;
    case "BS":
        objectivesVL.Push(new VariableScalar() { Value = "Hafgufa" }, changedBy);
        objectivesVL.Push(new VariableScalar() { Value = "Elasmosaurus" }, changedBy);
        break;
    case "TS":
        objectivesVL.Push(new VariableScalar() { Value = "Hafgufa" }, changedBy);
        objectivesVL.Push(new VariableScalar() { Value = "Placodus" }, changedBy);
        break;
    case "NS":
        objectivesVL.Push(new VariableScalar() { Value = "Seadragons" }, changedBy);
        objectivesVL.Push(new VariableScalar() { Value = "Coral Manta" }, changedBy);
        break;
    case "RS":
        objectivesVL.Push(new VariableScalar() { Value = "Sothis" }, changedBy);
        objectivesVL.Push(new VariableScalar() { Value = "Stonescale" }, changedBy);
        break;
    case "BN":
        objectivesVL.Push(new VariableScalar() { Value = "Mantas" }, changedBy);
        break;
    case "TN":
        objectivesVL.Push(new VariableScalar() { Value = "Fugu" }, changedBy);
        objectivesVL.Push(new VariableScalar() { Value = "Stonescale" }, changedBy);
        break;
    case "NN":
        objectivesVL.Push(new VariableScalar() { Value = "Octopodes" }, changedBy);
        break;
    case "RN":
        objectivesVL.Push(new VariableScalar() { Value = "Jellyfish" }, changedBy);
        break;
}

// Returns the route objectives to Triggernometry.
TriggernometryHelpers.SetListVariable(false, "oceanObjectives", objectivesVL);