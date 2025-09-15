# GS1 Barcode Parsing
This project provides tools for interpreting and parsing GS1-conformant barcodes. It extracts and returns a list of GS1 Segments (Application Identifiers and their associated values) from barcode data, enabling further processing and integration into business workflows.

## Features
- Parses a wide range of GS1 Application Identifiers (AIs), such as:
  - Serial Shipping Container Code (SSCC)
  - EAN Numbers
  - Charge Number
  - Producer Date, Packing Date, Expiry Date
  - Serial Number, Product Model
  - Global Location Numbers (GLN)
  - Various logistic measures (weight, volume, dimensions)
- Returns structured data for each segment, including type, length, and value.
