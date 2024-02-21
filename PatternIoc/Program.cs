using PatternIoc;


bus bus = new();
velo velo = new();
VoitureElectrique voiture = new();

// Person person = new("Igor", new (), new() );
Person person = new("Igor", bus);
Person personDeux = new("Igaur", velo);
Person personTrois = new("Igeaur", voiture);

person.AllerAuTravail(new("Paris"));