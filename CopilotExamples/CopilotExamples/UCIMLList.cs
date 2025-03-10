namespace CopilotExamples;

public class UCIMLList
{
    public static readonly UCIMLListRow[] Rows =
    [
        new() { Id = 1, DatasetName = "Abalone" },
        new() { Id = 2, DatasetName = "Adult" },
        new() { Id = 3, DatasetName = "Annealing" },
        new() { Id = 8, DatasetName = "Audiology (Standardized)" },
        new() { Id = 9, DatasetName = "Auto MPG" },
        new() { Id = 10, DatasetName = "Automobile" },
        new() { Id = 12, DatasetName = "Balance Scale" },
        new() { Id = 13, DatasetName = "Balloons" },
        new() { Id = 14, DatasetName = "Breast Cancer" },
        new() { Id = 15, DatasetName = "Breast Cancer Wisconsin (Original)" },
        new() { Id = 16, DatasetName = "Breast Cancer Wisconsin (Prognostic)" },
        new() { Id = 17, DatasetName = "Breast Cancer Wisconsin (Diagnostic)" },
        new() { Id = 18, DatasetName = "Pittsburgh Bridges" },
        new() { Id = 19, DatasetName = "Car Evaluation" },
        new() { Id = 20, DatasetName = "Census Income" },
        new() { Id = 22, DatasetName = "Chess (King-Rook vs. King-Pawn)" },
        new() { Id = 23, DatasetName = "Chess (King-Rook vs. King)" },
        new() { Id = 26, DatasetName = "Connect-4" },
        new() { Id = 27, DatasetName = "Credit Approval" },
        new() { Id = 28, DatasetName = "Japanese Credit Screening" },
        new() { Id = 29, DatasetName = "Computer Hardware" },
        new() { Id = 30, DatasetName = "Contraceptive Method Choice" },
        new() { Id = 31, DatasetName = "Covertype" },
        new() { Id = 32, DatasetName = "Cylinder Bands" },
        new() { Id = 33, DatasetName = "Dermatology" },
        new() { Id = 38, DatasetName = "Echocardiogram" },
        new() { Id = 39, DatasetName = "Ecoli" },
        new() { Id = 40, DatasetName = "Flags" },
        new() { Id = 42, DatasetName = "Glass Identification" },
        new() { Id = 43, DatasetName = "Haberman's Survival" },
        new() { Id = 44, DatasetName = "Hayes-Roth" },
        new() { Id = 45, DatasetName = "Heart Disease" },
        new() { Id = 46, DatasetName = "Hepatitis" },
        new() { Id = 47, DatasetName = "Horse Colic" },
        new() { Id = 50, DatasetName = "Image Segmentation" },
        new() { Id = 52, DatasetName = "Ionosphere" },
        new() { Id = 53, DatasetName = "Iris" },
        new() { Id = 54, DatasetName = "ISOLET" },
        new() { Id = 58, DatasetName = "Lenses" },
        new() { Id = 59, DatasetName = "Letter Recognition" },
        new() { Id = 60, DatasetName = "Liver Disorders" },
        new() { Id = 62, DatasetName = "Lung Cancer" },
        new() { Id = 63, DatasetName = "Lymphography" },
        new()
        {
            Id = 69,
            DatasetName = "Molecular Biology (Splice-junction Gene Sequences)"
        },
        new() { Id = 70, DatasetName = "MONK's Problems" },
        new() { Id = 73, DatasetName = "Mushroom" },
        new() { Id = 74, DatasetName = "Musk (Version 1)" },
        new() { Id = 75, DatasetName = "Musk (Version 2)" },
        new() { Id = 76, DatasetName = "Nursery" },
        new() { Id = 78, DatasetName = "Page Blocks Classification" },
        new()
        {
            Id = 80, DatasetName = "Optical Recognition of Handwritten Digits"
        },
        new()
        {
            Id = 81, DatasetName = "Pen-Based Recognition of Handwritten Digits"
        },
        new() { Id = 82, DatasetName = "Post-Operative Patient" },
        new() { Id = 83, DatasetName = "Primary Tumor" },
        new() { Id = 87, DatasetName = "Servo" },
        new() { Id = 88, DatasetName = "Shuttle Landing Control" },
        new() { Id = 89, DatasetName = "Solar Flare" },
        new() { Id = 90, DatasetName = "Soybean (Large)" },
        new() { Id = 91, DatasetName = "Soybean (Small)" },
        new() { Id = 92, DatasetName = "Challenger USA Space Shuttle O-Ring" },
        new() { Id = 94, DatasetName = "Spambase" },
        new() { Id = 95, DatasetName = "SPECT Heart" },
        new() { Id = 96, DatasetName = "SPECTF Heart" },
        new() { Id = 101, DatasetName = "Tic-Tac-Toe Endgame" },
        new() { Id = 105, DatasetName = "Congressional Voting Records" },
        new()
        {
            Id = 107, DatasetName = "Waveform Database Generator (Version 1)"
        },
        new() { Id = 109, DatasetName = "Wine" },
        new() { Id = 110, DatasetName = "Yeast" },
        new() { Id = 111, DatasetName = "Zoo" },
        new() { Id = 116, DatasetName = "US Census Data (1990)" },
        new() { Id = 117, DatasetName = "Census-Income (KDD)" },
        new() { Id = 122, DatasetName = "El Nino" },
        new()
        {
            Id = 143, DatasetName = "Statlog (Australian Credit Approval)"
        },
        new() { Id = 144, DatasetName = "Statlog (German Credit Data)" },
        new() { Id = 145, DatasetName = "Statlog (Heart)" },
        new() { Id = 146, DatasetName = "Statlog (Landsat Satellite)" },
        new() { Id = 147, DatasetName = "Statlog (Image Segmentation)" },
        new() { Id = 148, DatasetName = "Statlog (Shuttle)" },
        new() { Id = 149, DatasetName = "Statlog (Vehicle Silhouettes)" },
        new()
        {
            Id = 151,
            DatasetName = "Connectionist Bench (Sonar, Mines vs. Rocks)"
        },
        new() { Id = 155, DatasetName = "Cloud" },
        new() { Id = 158, DatasetName = "Poker Hand" },
        new() { Id = 159, DatasetName = "MAGIC Gamma Telescope" },
        new() { Id = 161, DatasetName = "Mammographic Mass" },
        new() { Id = 162, DatasetName = "Forest Fires" },
        new() { Id = 165, DatasetName = "Concrete Compressive Strength" },
        new() { Id = 172, DatasetName = "Ozone Level Detection" },
        new() { Id = 174, DatasetName = "Parkinsons" },
        new() { Id = 176, DatasetName = "Blood Transfusion Service Center" },
        new() { Id = 183, DatasetName = "Communities and Crime" },
        new() { Id = 184, DatasetName = "Acute Inflammations" },
        new() { Id = 186, DatasetName = "Wine Quality" },
        new() { Id = 189, DatasetName = "Parkinsons Telemonitoring" },
        new() { Id = 193, DatasetName = "Cardiotocography" },
        new() { Id = 198, DatasetName = "Steel Plates Faults" },
        new() { Id = 211, DatasetName = "Communities and Crime Unnormalized" },
        new() { Id = 212, DatasetName = "Vertebral Column" },
        new() { Id = 222, DatasetName = "Bank Marketing" },
        new() { Id = 225, DatasetName = "ILPD (Indian Liver Patient Dataset)" },
        new() { Id = 229, DatasetName = "Skin Segmentation" },
        new()
        {
            Id = 235,
            DatasetName = "Individual Household Electric Power Consumption"
        },
        new() { Id = 242, DatasetName = "Energy Efficiency" },
        new() { Id = 244, DatasetName = "Fertility" },
        new() { Id = 247, DatasetName = "ISTANBUL STOCK EXCHANGE" },
        new() { Id = 257, DatasetName = "User Knowledge Modeling" },
        new() { Id = 264, DatasetName = "EEG Eye State" },
        new() { Id = 267, DatasetName = "Banknote Authentication" },
        new()
        {
            Id = 270,
            DatasetName = "Gas Sensor Array Drift at Different Concentrations"
        },
        new() { Id = 275, DatasetName = "Bike Sharing" },
        new() { Id = 277, DatasetName = "Thoracic Surgery Data" },
        new() { Id = 291, DatasetName = "Airfoil Self-Noise" },
        new() { Id = 292, DatasetName = "Wholesale customers" },
        new() { Id = 294, DatasetName = "Combined Cycle Power Plant" },
        new()
        {
            Id = 296,
            DatasetName = "Diabetes 130-US Hospitals for Years 1999-2008"
        },
        new()
        {
            Id = 300, DatasetName = "Tennis Major Tournament Match Statistics"
        },
        new() { Id = 312, DatasetName = "Dow Jones Index" },
        new() { Id = 320, DatasetName = "Student Performance" },
        new() { Id = 327, DatasetName = "Phishing Websites" },
        new() { Id = 329, DatasetName = "Diabetic Retinopathy Debrecen" },
        new() { Id = 332, DatasetName = "Online News Popularity" },
        new() { Id = 336, DatasetName = "Chronic Kidney Disease" },
        new() { Id = 342, DatasetName = "Mice Protein Expression" },
        new() { Id = 350, DatasetName = "Default of Credit Card Clients" },
        new() { Id = 352, DatasetName = "Online Retail" },
        new() { Id = 357, DatasetName = "Occupancy Detection" },
        new() { Id = 360, DatasetName = "Air Quality" },
        new() { Id = 365, DatasetName = "Polish Companies Bankruptcy" },
        new() { Id = 367, DatasetName = "Dota2 Games Results" },
        new() { Id = 368, DatasetName = "Facebook Metrics" },
        new() { Id = 372, DatasetName = "HTRU2" },
        new() { Id = 373, DatasetName = "Drug Consumption (Quantified)" },
        new() { Id = 374, DatasetName = "Appliances Energy Prediction" },
        new() { Id = 379, DatasetName = "Website Phishing" },
        new() { Id = 380, DatasetName = "YouTube Spam Collection" },
        new() { Id = 381, DatasetName = "Beijing PM2.5" },
        new() { Id = 383, DatasetName = "Cervical Cancer (Risk Factors)" },
        new() { Id = 390, DatasetName = "Stock Portfolio Performance" },
        new() { Id = 396, DatasetName = "Sales Transactions Weekly" },
        new() { Id = 409, DatasetName = "Daily Demand Forecasting Orders" },
        new()
        {
            Id = 419,
            DatasetName =
                "Autistic Spectrum Disorder Screening Data for Children"
        },
        new() { Id = 426, DatasetName = "Autism Screening Adult" },
        new() { Id = 445, DatasetName = "Absenteeism at work" },
        new() { Id = 451, DatasetName = "Breast Cancer Coimbra" },
        new() { Id = 461, DatasetName = "Drug Reviews (Druglib.com)" },
        new() { Id = 462, DatasetName = "Drug Reviews (Drugs.com)" },
        new() { Id = 464, DatasetName = "Superconductivty Data" },
        new() { Id = 467, DatasetName = "Student Academics Performance" },
        new()
        {
            Id = 468,
            DatasetName = "Online Shoppers Purchasing Intention Dataset"
        },
        new()
        {
            Id = 471, DatasetName = "Electrical Grid Stability Simulated Data"
        },
        new() { Id = 477, DatasetName = "Real Estate Valuation" },
        new() { Id = 484, DatasetName = "Travel Reviews" },
        new() { Id = 485, DatasetName = "Travel Review Ratings" },
        new() { Id = 488, DatasetName = "Facebook Live Sellers in Thailand" },
        new() { Id = 492, DatasetName = "Metro Interstate Traffic Volume" },
        new()
        {
            Id = 503,
            DatasetName = "Hepatitis C Virus (HCV) for Egyptian patients"
        },
        new() { Id = 519, DatasetName = "Heart Failure Clinical Records" },
        new()
        {
            Id = 529, DatasetName = "Early Stage Diabetes Risk Prediction"
        },
        new() { Id = 536, DatasetName = "Pedestrians in Traffic" },
        new() { Id = 537, DatasetName = "Cervical Cancer Behavior Risk" },
        new()
        {
            Id = 544,
            DatasetName =
                "Estimation of Obesity Levels Based On Eating Habits and Physical Condition"
        },
        new() { Id = 545, DatasetName = "Rice (Cammeo and Osmancik)" },
        new() { Id = 547, DatasetName = "Algerian Forest Fires" },
        new()
        {
            Id = 551, DatasetName = "Gas Turbine CO and NOx Emission Data Set"
        },
        new() { Id = 555, DatasetName = "Apartment for Rent Classified" },
        new() { Id = 560, DatasetName = "Seoul Bike Sharing Demand" },
        new() { Id = 563, DatasetName = "Iranian Churn" },
        new() { Id = 565, DatasetName = "Bone marrow transplant: children" },
        new() { Id = 567, DatasetName = "COVID-19 Surveillance" },
        new() { Id = 571, DatasetName = "HCV data" },
        new() { Id = 572, DatasetName = "Taiwanese Bankruptcy Prediction" },
        new() { Id = 579, DatasetName = "Myocardial infarction complications" },
        new()
        {
            Id = 582,
            DatasetName = "Student Performance on an Entrance Examination"
        },
        new() { Id = 591, DatasetName = "Gender by Name" },
        new()
        {
            Id = 597,
            DatasetName = "Productivity Prediction of Garment Employees"
        },
        new()
        {
            Id = 601, DatasetName = "AI4I 2020 Predictive Maintenance Dataset"
        },
        new() { Id = 602, DatasetName = "Dry Bean" },
        new() { Id = 603, DatasetName = "In-Vehicle Coupon Recommendation" },
        new()
        {
            Id = 697,
            DatasetName = "Predict Students' Dropout and Academic Success"
        },
        new() { Id = 713, DatasetName = "Auction Verification" },
        new() { Id = 722, DatasetName = "NATICUSdroid (Android Permissions)" },
        new() { Id = 728, DatasetName = "Toxicity" },
        new() { Id = 732, DatasetName = "DARWIN" },
        new() { Id = 755, DatasetName = "Accelerometer Gyro Mobile Phone" },
        new()
        {
            Id = 759,
            DatasetName = "Glioma Grading Clinical and Mutation Features"
        },
        new() { Id = 760, DatasetName = "Multivariate Gait Data" },
        new() { Id = 763, DatasetName = "Land Mines" },
        new()
        {
            Id = 799,
            DatasetName = "Single Elder Home Monitoring: Gas and Position"
        },
        new()
        {
            Id = 827, DatasetName = "Sepsis Survival Minimal Clinical Records"
        },
        new() { Id = 848, DatasetName = "Secondary Mushroom" },
        new() { Id = 849, DatasetName = "Power Consumption of Tetouan City" },
        new() { Id = 850, DatasetName = "Raisin" },
        new() { Id = 851, DatasetName = "Steel Industry Energy Consumption" },
        new()
        {
            Id = 856,
            DatasetName = "Higher Education Students Performance Evaluation"
        },
        new()
        {
            Id = 857,
            DatasetName = "Risk Factor Prediction of Chronic Kidney Disease"
        },
        new() { Id = 863, DatasetName = "Maternal Health Risk" },
        new() { Id = 864, DatasetName = "Room Occupancy Estimation" },
        new()
        {
            Id = 878, DatasetName = "Cirrhosis Patient Survival Prediction"
        },
        new() { Id = 880, DatasetName = "SUPPORT2" },
        new()
        {
            Id = 887,
            DatasetName =
                "National Health and Nutrition Health Survey 2013-2014 (NHANES) Age Prediction Subset"
        },
        new()
        {
            Id = 890, DatasetName = "AIDS Clinical Trials Group Study 175"
        },
        new() { Id = 891, DatasetName = "CDC Diabetes Health Indicators" },
        new() { Id = 911, DatasetName = "Recipe Reviews and User Feedback" },
        new()
        {
            Id = 913,
            DatasetName = "Forty Soybean Cultivars from Subsequent Harvests"
        },
        new()
        {
            Id = 915, DatasetName = "Differentiated Thyroid Cancer Recurrence"
        },
        new() { Id = 925, DatasetName = "Infrared Thermography Temperature" },
        new()
        {
            Id = 936, DatasetName = "National Poll on Healthy Aging (NPHA)"
        },
        new() { Id = 938, DatasetName = "Regensburg Pediatric Appendicitis" },
        new() { Id = 942, DatasetName = "RT-IoT2022" },
        new() { Id = 967, DatasetName = "PhiUSIIL Phishing URL (Website)" }
    ];
}

public class UCIMLListRow
{
    public int Id { get; set; }
    public string DatasetName { get; set; }
}

/*
Dataset Name                                                                            ID
   ------------                                                                            --
   Abalone                                                                                 1
   Adult                                                                                   2
   Annealing                                                                               3
   Audiology (Standardized)                                                                8
   Auto MPG                                                                                9
   Automobile                                                                              10
   Balance Scale                                                                           12
   Balloons                                                                                13
   Breast Cancer                                                                           14
   Breast Cancer Wisconsin (Original)                                                      15
   Breast Cancer Wisconsin (Prognostic)                                                    16
   Breast Cancer Wisconsin (Diagnostic)                                                    17
   Pittsburgh Bridges                                                                      18
   Car Evaluation                                                                          19
   Census Income                                                                           20
   Chess (King-Rook vs. King-Pawn)                                                         22
   Chess (King-Rook vs. King)                                                              23
   Connect-4                                                                               26
   Credit Approval                                                                         27
   Japanese Credit Screening                                                               28
   Computer Hardware                                                                       29
   Contraceptive Method Choice                                                             30
   Covertype                                                                               31
   Cylinder Bands                                                                          32
   Dermatology                                                                             33
   Echocardiogram                                                                          38
   Ecoli                                                                                   39
   Flags                                                                                   40
   Glass Identification                                                                    42
   Haberman's Survival                                                                     43
   Hayes-Roth                                                                              44
   Heart Disease                                                                           45
   Hepatitis                                                                               46
   Horse Colic                                                                             47
   Image Segmentation                                                                      50
   Ionosphere                                                                              52
   Iris                                                                                    53
   ISOLET                                                                                  54
   Lenses                                                                                  58
   Letter Recognition                                                                      59
   Liver Disorders                                                                         60
   Lung Cancer                                                                             62
   Lymphography                                                                            63
   Molecular Biology (Splice-junction Gene Sequences)                                      69
   MONK's Problems                                                                         70
   Mushroom                                                                                73
   Musk (Version 1)                                                                        74
   Musk (Version 2)                                                                        75
   Nursery                                                                                 76
   Page Blocks Classification                                                              78
   Optical Recognition of Handwritten Digits                                               80
   Pen-Based Recognition of Handwritten Digits                                             81
   Post-Operative Patient                                                                  82
   Primary Tumor                                                                           83
   Servo                                                                                   87
   Shuttle Landing Control                                                                 88
   Solar Flare                                                                             89
   Soybean (Large)                                                                         90
   Soybean (Small)                                                                         91
   Challenger USA Space Shuttle O-Ring                                                     92
   Spambase                                                                                94
   SPECT Heart                                                                             95
   SPECTF Heart                                                                            96
   Tic-Tac-Toe Endgame                                                                     101
   Congressional Voting Records                                                            105
   Waveform Database Generator (Version 1)                                                 107
   Wine                                                                                    109
   Yeast                                                                                   110
   Zoo                                                                                     111
   US Census Data (1990)                                                                   116
   Census-Income (KDD)                                                                     117
   El Nino                                                                                 122
   Statlog (Australian Credit Approval)                                                    143
   Statlog (German Credit Data)                                                            144
   Statlog (Heart)                                                                         145
   Statlog (Landsat Satellite)                                                             146
   Statlog (Image Segmentation)                                                            147
   Statlog (Shuttle)                                                                       148
   Statlog (Vehicle Silhouettes)                                                           149
   Connectionist Bench (Sonar, Mines vs. Rocks)                                            151
   Cloud                                                                                   155
   Poker Hand                                                                              158
   MAGIC Gamma Telescope                                                                   159
   Mammographic Mass                                                                       161
   Forest Fires                                                                            162
   Concrete Compressive Strength                                                           165
   Ozone Level Detection                                                                   172
   Parkinsons                                                                              174
   Blood Transfusion Service Center                                                        176
   Communities and Crime                                                                   183
   Acute Inflammations                                                                     184
   Wine Quality                                                                            186
   Parkinsons Telemonitoring                                                               189
   Cardiotocography                                                                        193
   Steel Plates Faults                                                                     198
   Communities and Crime Unnormalized                                                      211
   Vertebral Column                                                                        212
   Bank Marketing                                                                          222
   ILPD (Indian Liver Patient Dataset)                                                     225
   Skin Segmentation                                                                       229
   Individual Household Electric Power Consumption                                         235
   Energy Efficiency                                                                       242
   Fertility                                                                               244
   ISTANBUL STOCK EXCHANGE                                                                 247
   User Knowledge Modeling                                                                 257
   EEG Eye State                                                                           264
   Banknote Authentication                                                                 267
   Gas Sensor Array Drift at Different Concentrations                                      270
   Bike Sharing                                                                            275
   Thoracic Surgery Data                                                                   277
   Airfoil Self-Noise                                                                      291
   Wholesale customers                                                                     292
   Combined Cycle Power Plant                                                              294
   Diabetes 130-US Hospitals for Years 1999-2008                                           296
   Tennis Major Tournament Match Statistics                                                300
   Dow Jones Index                                                                         312
   Student Performance                                                                     320
   Phishing Websites                                                                       327
   Diabetic Retinopathy Debrecen                                                           329
   Online News Popularity                                                                  332
   Chronic Kidney Disease                                                                  336
   Mice Protein Expression                                                                 342
   Default of Credit Card Clients                                                          350
   Online Retail                                                                           352
   Occupancy Detection                                                                     357
   Air Quality                                                                             360
   Polish Companies Bankruptcy                                                             365
   Dota2 Games Results                                                                     367
   Facebook Metrics                                                                        368
   HTRU2                                                                                   372
   Drug Consumption (Quantified)                                                           373
   Appliances Energy Prediction                                                            374
   Website Phishing                                                                        379
   YouTube Spam Collection                                                                 380
   Beijing PM2.5                                                                           381
   Cervical Cancer (Risk Factors)                                                          383
   Stock Portfolio Performance                                                             390
   Sales Transactions Weekly                                                               396
   Daily Demand Forecasting Orders                                                         409
   Autistic Spectrum Disorder Screening Data for Children                                  419
   Autism Screening Adult                                                                  426
   Absenteeism at work                                                                     445
   Breast Cancer Coimbra                                                                   451
   Drug Reviews (Druglib.com)                                                              461
   Drug Reviews (Drugs.com)                                                                462
   Superconductivty Data                                                                   464
   Student Academics Performance                                                           467
   Online Shoppers Purchasing Intention Dataset                                            468
   Electrical Grid Stability Simulated Data                                                471
   Real Estate Valuation                                                                   477
   Travel Reviews                                                                          484
   Travel Review Ratings                                                                   485
   Facebook Live Sellers in Thailand                                                       488
   Metro Interstate Traffic Volume                                                         492
   Hepatitis C Virus (HCV) for Egyptian patients                                           503
   Heart Failure Clinical Records                                                          519
   Early Stage Diabetes Risk Prediction                                                    529
   Pedestrians in Traffic                                                                  536
   Cervical Cancer Behavior Risk                                                           537
   Estimation of Obesity Levels Based On Eating Habits and Physical Condition              544
   Rice (Cammeo and Osmancik)                                                              545
   Algerian Forest Fires                                                                   547
   Gas Turbine CO and NOx Emission Data Set                                                551
   Apartment for Rent Classified                                                           555
   Seoul Bike Sharing Demand                                                               560
   Iranian Churn                                                                           563
   Bone marrow transplant: children                                                        565
   COVID-19 Surveillance                                                                   567
   HCV data                                                                                571
   Taiwanese Bankruptcy Prediction                                                         572
   Myocardial infarction complications                                                     579
   Student Performance on an Entrance Examination                                          582
   Gender by Name                                                                          591
   Productivity Prediction of Garment Employees                                            597
   AI4I 2020 Predictive Maintenance Dataset                                                601
   Dry Bean                                                                                602
   In-Vehicle Coupon Recommendation                                                        603
   Predict Students' Dropout and Academic Success                                          697
   Auction Verification                                                                    713
   NATICUSdroid (Android Permissions)                                                      722
   Toxicity                                                                                728
   DARWIN                                                                                  732
   Accelerometer Gyro Mobile Phone                                                         755
   Glioma Grading Clinical and Mutation Features                                           759
   Multivariate Gait Data                                                                  760
   Land Mines                                                                              763
   Single Elder Home Monitoring: Gas and Position                                          799
   Sepsis Survival Minimal Clinical Records                                                827
   Secondary Mushroom                                                                      848
   Power Consumption of Tetouan City                                                       849
   Raisin                                                                                  850
   Steel Industry Energy Consumption                                                       851
   Higher Education Students Performance Evaluation                                        856
   Risk Factor Prediction of Chronic Kidney Disease                                        857
   Maternal Health Risk                                                                    863
   Room Occupancy Estimation                                                               864
   Cirrhosis Patient Survival Prediction                                                   878
   SUPPORT2                                                                                880
   National Health and Nutrition Health Survey 2013-2014 (NHANES) Age Prediction Subset    887
   AIDS Clinical Trials Group Study 175                                                    890
   CDC Diabetes Health Indicators                                                          891
   Recipe Reviews and User Feedback                                                        911
   Forty Soybean Cultivars from Subsequent Harvests                                        913
   Differentiated Thyroid Cancer Recurrence                                                915
   Infrared Thermography Temperature                                                       925
   National Poll on Healthy Aging (NPHA)                                                   936
   Regensburg Pediatric Appendicitis                                                       938
   RT-IoT2022                                                                              942
   PhiUSIIL Phishing URL (Website)                                                         967
*/