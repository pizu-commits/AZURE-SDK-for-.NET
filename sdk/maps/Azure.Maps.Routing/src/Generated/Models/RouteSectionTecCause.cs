// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Maps.Routing.Models
{
    /// <summary> The cause of the traffic event. Can contain mainCauseCode and subCauseCode elements. Can be used to define iconography and descriptions. </summary>
    public partial class RouteSectionTecCause
    {
        /// <summary> Initializes a new instance of <see cref="RouteSectionTecCause"/>. </summary>
        internal RouteSectionTecCause()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RouteSectionTecCause"/>. </summary>
        /// <param name="mainCauseCode"> The main cause of the traffic event. Contains a value in the tec002:CauseCode table, as defined in the [TPEG2-TEC](https://www.iso.org/standard/63116.html) standard. </param>
        /// <param name="subCauseCode"> The subcause of the traffic event. Contains a value in the sub cause table defined by the mainCauseCode, as defined in the [TPEG2-TEC](https://www.iso.org/standard/63116.html) standard. </param>
        internal RouteSectionTecCause(int? mainCauseCode, int? subCauseCode)
        {
            MainCauseCode = mainCauseCode;
            SubCauseCode = subCauseCode;
        }

        /// <summary> The main cause of the traffic event. Contains a value in the tec002:CauseCode table, as defined in the [TPEG2-TEC](https://www.iso.org/standard/63116.html) standard. </summary>
        public int? MainCauseCode { get; }
        /// <summary> The subcause of the traffic event. Contains a value in the sub cause table defined by the mainCauseCode, as defined in the [TPEG2-TEC](https://www.iso.org/standard/63116.html) standard. </summary>
        public int? SubCauseCode { get; }
    }
}
