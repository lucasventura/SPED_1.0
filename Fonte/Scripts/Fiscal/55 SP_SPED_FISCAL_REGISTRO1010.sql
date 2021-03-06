CREATE PROCEDURE SP_SPED_FISCAL_REGISTRO1010 (
    CD_EMPRESA VARCHAR(3),
    DT_EMI_INICIAL DATE,
    DT_EMI_FINAL DATE)
RETURNS (
    IND_EXP VARCHAR(1),
    IND_CCRF VARCHAR(1),
    IND_COMB VARCHAR(1),
    IND_USINA VARCHAR(1),
    IND_VA VARCHAR(1),
    IND_EE VARCHAR(1),
    IND_CART VARCHAR(1),
    IND_FORM VARCHAR(1),
    IND_AER VARCHAR(1)
)
AS
BEGIN

    SELECT
        'S' AS IND_EXP,
        'N' AS IND_CCRF,
        'S' AS IND_COMB,
        'N' AS IND_USINA,
        'S' AS IND_VA,
        'N' AS IND_EE,
        'S' AS IND_CART,
        'N' AS IND_FORM,
        'S' AS IND_AER
    FROM RDB$DATABASE
    INTO
        :IND_EXP,
        :IND_CCRF,
        :IND_COMB,
        :IND_USINA,
        :IND_VA,
        :IND_EE,
        :IND_CART,
        :IND_FORM,
        :IND_AER;

    SUSPEND;

END
